Shader "CustomShader_PP"
{
    Properties
    {
        _MainTex ("Sprite Texture", 2D) = "white" {}
        _RenderTex ("Render Texture", 2D) = "white" {}
        _ColorBlend ("Color Blend", Color) = (1,1,1,1)
        _Level("Color Blend Level", Range(0,1)) = 0
        _EnableColorBlend("Enable Color Blend", Float) = 0 
        [HideInInspector] PixelSnap ("Pixel snap", Float) = 0
        [HideInInspector] _RendererColor ("RendererColor", Color) = (1,1,1,1)
        [HideInInspector] _Flip ("Flip", Vector) = (1,1,1,1)
        _BlendSrc ("Blend Source", Float) = 5
        _BlendDst ("Blend Destination", Float) = 10
    }

    SubShader
    {
        Tags {"Queue" = "Transparent" "RenderType" = "Transparent" "RenderPipeline" = "UniversalPipeline" }
        Blend [_BlendSrc] [_BlendDst]
        //Blend SrcAlpha OneMinusSrcAlpha
        Cull Off
        ZWrite Off

        Pass
        {
            HLSLPROGRAM
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #if defined(DEBUG_DISPLAY)
            #include "Packages/com.unity.render-pipelines.universal/Shaders/2D/Include/InputData2D.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/Shaders/2D/Include/SurfaceData2D.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Debug/Debugging2D.hlsl"
            #endif

            #pragma vertex UnlitVertex
            #pragma fragment UnlitFragment

            #pragma multi_compile _ DEBUG_DISPLAY

            struct Attributes
            {
                float3 positionOS   : POSITION;
                float4 color        : COLOR;
                float2 uv           : TEXCOORD0;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct Varyings
            {
                float4  positionCS  : SV_POSITION;
                half4   color       : COLOR;
                float2  uv          : TEXCOORD0;
                #if defined(DEBUG_DISPLAY)
                float3  positionWS  : TEXCOORD2;
                #endif
                UNITY_VERTEX_OUTPUT_STEREO
            };

            TEXTURE2D(_MainTex);
            SAMPLER(sampler_MainTex);
            TEXTURE2D(_RenderTex);
            SAMPLER(sampler_RenderTex);
            half4 _MainTex_ST;
            float4 _ColorBlend;
            float _Level;
            half4 _RendererColor;
            float _EnableColorBlend;
            // RGB to HSL conversion
            float3 RGBToHSL(float3 color)
            {
                float maxVal = max(color.r, max(color.g, color.b));
                float minVal = min(color.r, min(color.g, color.b));
                float delta = maxVal - minVal;

                float3 hsl;
                hsl.z = (maxVal + minVal) / 2.0;  // Lightness

                if (delta == 0.0)
                {
                    hsl.x = 0.0;  // Hue
                    hsl.y = 0.0;  // Saturation
                }
                else
                {
                    hsl.y = (hsl.z < 0.5) ? (delta / (maxVal + minVal)) : (delta / (2.0 - maxVal - minVal));  // Saturation
                    float delta_r = (((maxVal - color.r) / 6.0) + (delta / 2.0)) / delta;
                    float delta_g = (((maxVal - color.g) / 6.0) + (delta / 2.0)) / delta;
                    float delta_b = (((maxVal - color.b) / 6.0) + (delta / 2.0)) / delta;

                    if (color.r == maxVal)
                        hsl.x = delta_b - delta_g;
                    else if (color.g == maxVal)
                        hsl.x = (1.0 / 3.0) + delta_r - delta_b;
                    else if (color.b == maxVal)
                        hsl.x = (2.0 / 3.0) + delta_g - delta_r;

                    if (hsl.x < 0.0)
                        hsl.x += 1.0;
                    if (hsl.x > 1.0)
                        hsl.x -= 1.0;
                }

                return hsl;
            }
            // HSL to RGB conversion
            float3 HSLToRGB(float3 hsl)
            {
                float3 rgb;
                float c = (1.0 - abs(2.0 * hsl.z - 1.0)) * hsl.y;  // Chroma
                float x = c * (1.0 - abs(fmod(hsl.x * 6.0, 2.0) - 1.0));
                float m = hsl.z - c / 2.0;

                if (0.0 <= hsl.x && hsl.x < 1.0 / 6.0)
                    rgb = float3(c, x, 0.0);
                else if (1.0 / 6.0 <= hsl.x && hsl.x < 2.0 / 6.0)
                    rgb = float3(x, c, 0.0);
                else if (2.0 / 6.0 <= hsl.x && hsl.x < 3.0 / 6.0)
                    rgb = float3(0.0, c, x);
                else if (3.0 / 6.0 <= hsl.x && hsl.x < 4.0 / 6.0)
                    rgb = float3(0.0, x, c);
                else if (4.0 / 6.0 <= hsl.x && hsl.x < 5.0 / 6.0)
                    rgb = float3(x, 0.0, c);
                else
                    rgb = float3(c, 0.0, x);

                return rgb + m;
            }

            Varyings UnlitVertex(Attributes v)
            {
                Varyings o = (Varyings)0;
                UNITY_SETUP_INSTANCE_ID(v);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);

                o.positionCS = TransformObjectToHClip(v.positionOS);
                #if defined(DEBUG_DISPLAY)
                o.positionWS = TransformObjectToWorld(v.positionOS);
                #endif
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                o.color = v.color * _RendererColor;
                return o;
            }

            half4 UnlitFragment(Varyings i) : SV_Target
            {
                float4 mainTex = i.color * SAMPLE_TEXTURE2D(_RenderTex, sampler_RenderTex, i.uv);
                float3 hsl;
                hsl.x=RGBToHSL(_ColorBlend.rgb).x;
                hsl.y=RGBToHSL(_ColorBlend.rgb).y;
                hsl.z=RGBToHSL(mainTex.rgb).z;
                if(_EnableColorBlend!=0){
                    mainTex.rgb=_Level*HSLToRGB(hsl)+(1-_Level)*mainTex.rgb;
                }
                #if defined(DEBUG_DISPLAY)
                SurfaceData2D surfaceData;
                InputData2D inputData;
                half4 debugColor = 0;

                InitializeSurfaceData(mainTex.rgb, mainTex.a, surfaceData);
                InitializeInputData(i.uv, inputData);
                SETUP_DEBUG_DATA_2D(inputData, i.positionWS);

                if(CanDebugOverrideOutputColor(surfaceData, inputData, debugColor))
                {
                    return debugColor;
                }
                #endif

                return mainTex;
            }
            ENDHLSL
        }

    }
    Fallback "Sprites/Default"
}
