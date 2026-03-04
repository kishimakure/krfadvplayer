Shader "CustomShader_COMMON"
{
    Properties
    {
        _MainTex            ("Sprite Texture", 2D) = "white" {}
        _AlphaTex           ("Alpha Texture", 2D) = "white" {}
        _MeshColor          ("Mesh Color", Color) = (1,1,1,1)
        _MatColor           ("Material Color", Color) = (1,1,1,1)
        [HideInInspector] PixelSnap ("Pixel snap", Float) = 0
        [HideInInspector] _RendererColor ("RendererColor", Color) = (1,1,1,1)
        [HideInInspector] _Flip ("Flip", Vector) = (1,1,1,1)
        _HDRFactor          ("HDR Factor", Range(0.01,10)) = 1
        _BlendSrc           ("Blend Source", Float) = 5
        _BlendDst           ("Blend Destination", Float) = 10
        _MainRotation       ("Main Rotation", Range(-1.6,1.6)) = 0
        _DistortionLevel    ("Distortion Level", Float) = 0
        _Texture_Noise      ("Noise",  2D) = "gray"  {}
        _Texture_Level      ("Level",  2D) = "white" {}
        _NoiseTextureParam  ("Noise Texture Param", Vector) = (0,0,1,1)
        _LevelTextureParam  ("Level Texture Param", Vector) = (0,0,1,1)
        _EnableDistortion   ("Enable Distortion", Float) = 0
        _Warp               ("Warp", Float) = 0
        _MulColor           ("Mul Color", Color) = (1,1,0.5019608,1)
        _AddColor           ("Add Color", Color) = (0.5019608,0.5019608,0.5019608,1)
        _BaseAddColor       ("Base Add Color", Color) = (0,0,0,1)
        _ChangeHDRFactor    ("Change HDRFactor", Range(0.01, 10)) = 0.75
        _ChangeThreshold    ("Change Threshold", Range(0.001, 1)) = 0.15
        _ProgressRate       ("Progress Rate", Range(0, 1)) = 0
        _FadeThreshold      ("Fade Threshold", Range(0.001, 1)) = 0.2
        _FirstCommonVelocity("First Common Velocity (xy start, zw end)", Vector) = (0,0,0,0)
        _FirstNormalVelocity("First Normal Velocity (xy start, zw end)", Vector) = (-0.5, 0.8, 0.5, 1)
        _Gravity            ("Gravity (xy start, zw end)", Vector) = (-0.5,0,0.5,0)
        _NormalGravity      ("NormalGravity (xy start, zw end)", Vector) = (0,0,0,0)
        _ShapeArgment       ("Shape Arg (xy origin, zw dir; |w|>=1 => y-gate)", Vector) = (0.5, 0.1, 0, 1)
        _AlphaTestRefValue  ("AlphaTest Reference Value", Range(0, 1)) = 0.01
        _UVRect             ("UV Rect", Vector) = (0,0,1,1)
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
            TEXTURE2D(_AlphaTex);
            TEXTURE2D(_Texture_Noise);
            TEXTURE2D(_Texture_Level);
            SAMPLER(sampler_MainTex);
            SAMPLER(sampler_AlphaTex);
            SAMPLER(sampler_Texture_Noise);
            SAMPLER(sampler_Texture_Level);
            half4 _MainTex_ST;
            float4 _MeshColor;
            float4 _MatColor;
            half4 _RendererColor;
            float _HDRFactor;
            float _MainRotation;
            float _DistortionLevel;
            float _Warp;
            float4 _NoiseTextureParam;
            float4 _LevelTextureParam;
            float _EnableDistortion;
            half4 _MulColor, _AddColor, _BaseAddColor;
            float  _ChangeHDRFactor;
            float  _ChangeThreshold, _ProgressRate, _FadeThreshold;
            float4 _FirstCommonVelocity, _FirstNormalVelocity;
            float4 _Gravity, _NormalGravity;
            float4 _ShapeArgment;
            float _AlphaTestRefValue;
            float4 _UVRect;
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
                float cosA = cos(_MainRotation);
                float sinA = sin(_MainRotation);
                float2x2 rotationMatrix = float2x2(cosA, -sinA, sinA, cosA);
                float2 uv = o.uv;
                uv = mul(uv - 0.5, rotationMatrix)+0.5;
                o.uv = uv;
                float4 ColorBlend;
                ColorBlend.rgb = _MeshColor.rgb * _MatColor.rgb;
                ColorBlend.a = _MeshColor.a * _MatColor.a;
                o.color = v.color * ColorBlend * _RendererColor;
                return o;
            }

            float dist_to_line(float2 p, float2 origin, float2 n_unit)
            {
                float2 n_perp = float2(-n_unit.y, n_unit.x);
                return abs(dot(n_perp, p - origin)); // 与 wiki 公式等价
            }

            half4 UnlitFragment(Varyings i) : SV_Target
            { 
                half4 mainTex;
                half alpha;
                float2 uvZ = i.uv * _UVRect.zw + _UVRect.xy;
                if(_EnableDistortion != 0){
                    float2 uvN = uvZ * _NoiseTextureParam.zw + _NoiseTextureParam.xy;
                    float n = SAMPLE_TEXTURE2D(_Texture_Noise, sampler_Texture_Noise, uvN).r;

                    float a1 = n * 6.28318548 - 3.14159274; // 2πn - π
                    float a2 = n * 3.14159274;              // πn
                    float2 dir = float2(cos(a2), sin(a1));
                    float2 off = dir * _DistortionLevel;

                    float2 uvL = uvZ * _LevelTextureParam.zw + _LevelTextureParam.xy;
                    float2 lvl = SAMPLE_TEXTURE2D(_Texture_Level, sampler_Texture_Level, uvL).rg;
                    
                    float2 uv  = uvZ + off * lvl;
                    mainTex = i.color * SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, uv);
                    alpha = SAMPLE_TEXTURE2D(_AlphaTex, sampler_AlphaTex, uv).a;
                    
                }else if(_Warp != 0){


                    float2 p = uvZ;
                    float  dline = 1.0 - p.y;
                    float  tloc = saturate(2.0 * (_ProgressRate - 0.5 * dline));


                    
                    float2 vcom_mid = (_FirstCommonVelocity.xy + _FirstCommonVelocity.zw) * 0.5;
                    float2 gcom_mid = (_Gravity.xy            + _Gravity.zw           ) * 0.5;

                    float2 duv_v    = vcom_mid * _ProgressRate;
                    float2 duv_a    = gcom_mid * (_ProgressRate * _ProgressRate);
                    float2 uv_noise = (p - (duv_v + duv_a)) * _NoiseTextureParam.zw + _NoiseTextureParam.xy;

                    float  n0 = SAMPLE_TEXTURE2D(_Texture_Noise, sampler_Texture_Noise, uv_noise).r;
                    float  n1 = SAMPLE_TEXTURE2D(_Texture_Noise, sampler_Texture_Noise, uv_noise + 0.25).r;
                    float  n2 = SAMPLE_TEXTURE2D(_Texture_Noise, sampler_Texture_Noise, uv_noise + 0.5).r;
                    float  n3 = SAMPLE_TEXTURE2D(_Texture_Noise, sampler_Texture_Noise, uv_noise + 0.75).r;

                    float2 vnor = lerp(_FirstNormalVelocity.xy, _FirstNormalVelocity.zw, n1);
                    float2 gnor = lerp(_NormalGravity.xy,      _NormalGravity.zw,      n3);
                    float2 vcom = lerp(_FirstCommonVelocity.xy,_FirstCommonVelocity.zw, n0);
                    float2 gcom = lerp(_Gravity.xy,            _Gravity.zw,            n2);


                    float2 origin = _ShapeArgment.xy;
                    float2 dir    = _ShapeArgment.zw;
                    float2 n      = normalize(dir);
                    float  side   = dot(n, p - origin);
                    float  sgn    = (_ShapeArgment.w >= 0.0) ? -1.0 : 1.0;
                    float2 n_side = n * sgn;

                    float2 V = vcom - n_side * vnor;
                    float2 G = gcom - n_side * gnor;


                    float2 d_uv_content = V * tloc + G * (tloc * tloc);


                    float2 q = uvZ - d_uv_content;
                    mainTex = i.color * SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, q);
                    
                    if (q.x < 0.0 || q.x > 1.0 || q.y < 0.0 || q.y > 1.0)
                    {
                        mainTex = float4(0, 0, 0, 0);
                    }


                    float  k    = saturate(tloc / max(_ChangeThreshold, 1e-6));
                    float3 mulC = lerp(1.0.xxx, _MulColor.rgb, k);
                    float3 addC = k * _AddColor.rgb;
                    float  hdr  = lerp(_HDRFactor, _ChangeHDRFactor, k);

                    alpha       = SAMPLE_TEXTURE2D(_AlphaTex, sampler_AlphaTex, q).a;
                    float3 baseC= mainTex.rgb * mulC + addC;
                    mainTex.rgb = baseC / max(hdr, 1e-6) + _BaseAddColor.rgb;

                    float  fade = 1.0 - saturate((tloc - (1.0 - _FadeThreshold)) / max(_FadeThreshold, 1e-6));
                    mainTex.a   = fade * mainTex.a * _BaseAddColor.a;

                    
                }else{
                    mainTex = i.color * SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, uvZ);
                    alpha = SAMPLE_TEXTURE2D(_AlphaTex, sampler_AlphaTex, uvZ).a;
                }

                mainTex.a *= alpha;
                mainTex.rgb /=_HDRFactor;
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
