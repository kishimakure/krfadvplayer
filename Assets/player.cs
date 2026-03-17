using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.Networking;
using System;
using UnityEditor;
using Unity.Mathematics;
using UnityEditor.Rendering;
using UnityEngine.Rendering.Universal;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine.EventSystems;
#if !UNITY_EDITOR
using UnityEngine.Rendering;
using UnityEngine.Scripting;
[Preserve]
public class SkipUnityLogo
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
    private static void BeforeSplashScreen()
    {
#if UNITY_WEBGL
        Application.focusChanged+=Application_focusChanged;
#else
        System.Threading.Tasks.Task.Run(AsyncSkip);
#endif
    }
#if UNITY_WEBGL
    private static void Application_focusChanged(bool obj)
    {
        Application.focusChanged-=Application_focusChanged;
        SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
    }
#else
    private static void AsyncSkip()
    {
        SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
    }
#endif
}
#endif
public class Parameters
{
    public string Host { get; set; }
    public List<int> ADVIDs { get; set; }
    public int Width;
    public string Font { get; set; }
    public string AudioMode { get; set; }
    public Parameters_volume Volume { get; set; }
}
public class Parameters_volume
{
    public float BGM { get; set; }
    public float SE { get; set; }
    public float Voice { get; set; }
}
public class class_GameObject
{
    public int FileID { get; set; }
    public int PathID { get; set; }
}
public class advscript_Params
{
    public int ScriptID { get; set; }
    public string ScriptName { get; set; }
    public List<class_FuncParam> FuncParam { get; set; }
}
public class class_FuncParam
{
    public string funcName { get; set; }
    public int argNum { get; set; }
    public int argType1 { get; set; }
    public string m_value1 { get; set; }
    public int argType2 { get; set; }
    public string m_value2 { get; set; }
    public int argType3 { get; set; }
    public string m_value3 { get; set; }
    public int argType4 { get; set; }
    public string m_value4 { get; set; }
    public int argType5 { get; set; }
    public string m_value5 { get; set; }
    public int argType6 { get; set; }
    public string m_value6 { get; set; }
}
public class comicscript
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<comicscript_Params> m_Params { get; set; }
}
public class comicscript_Params
{
    public string m_ComicName { get; set; }
    public List<comicscript_Params_Data> m_Datas { get; set; }
}
public class comicscript_Params_Data
{
    public string m_CommandName { get; set; }
    public List<string> m_Args { get; set; }
}
public class comicspritelist
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<comicspritelist_Params> m_Params { get; set; }
}
public class comicspritelist_Params
{
    public string m_ComicName { get; set; }
    public List<comicspritelist_Params_Data> m_Data { get; set; }
}
public class comicspritelist_Params_Data
{
    public string m_RefName { get; set; }
    public string m_ResourceName { get; set; }
    public float m_X { get; set; }
    public float m_Y { get; set; }
    public int m_CellNo { get; set; }
}
public class advscript
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<advscript_Params> m_Params { get; set; }
}
public class advscripttext
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<advscripttext_Params> m_Params { get; set; }
}
public class advscripttext_Params
{
    public uint m_ID { get; set; }
    public string m_charaName { get; set; }
    public string m_text { get; set; }
    public string m_voiceLabel { get; set; }
}
public class advcharacterlist
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<advcharacterlist_Params> m_Params { get; set; }
}
public class advcharacterlist_Params
{
    public string m_ADVCharaID { get; set; }
    public string m_ResourceBaseName { get; set; }
    public string m_DisplayName { get; set; }
    public int m_NamedType { get; set; }
    public string m_CueSheet { get; set; }
    public List<advclist_Params_Data> m_Datas { get; set; }
}
public class advclist_Params_Data
{
    public int m_PoseID { get; set; }
    public string m_PoseName { get; set; }
    public float m_OffsetX { get; set; }
    public float m_OffsetY { get; set; }
    public int m_DummyStandPic { get; set; }
    public int m_FacePattern { get; set; }
    public float m_FacePivotX { get; set; }
    public float m_FacePivotY { get; set; }
    public float m_FacePicX { get; set; }
    public float m_FacePicY { get; set; }
    public int m_FaceReferenceImageType { get; set; }
    public float m_FaceX { get; set; }
    public float m_FaceY { get; set; }
    public float m_EmoOffsetX { get; set; }
    public float m_EmoOffsetY { get; set; }
    public float m_FootOffsetX { get; set; }
    public float m_FootOffsetY { get; set; }

}
public class advlist
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<advlist_Params> m_Params { get; set; }
}
public class advlist_Params
{
    public int m_AdvID { get; set; }
    public int m_Category { get; set; }
    public string m_ScriptName { get; set; }
    public string m_ScriptTextName { get; set; }
    public string m_CueSheet { get; set; }
    public int m_CRIVersion { get; set; }
    public string m_MovieFileName { get; set; }
    public string m_ComicGroupName { get; set; }
    public string m_ComicName { get; set; }
    public string m_Title { get; set; }
    public int m_LibraryID { get; set; }
    public List<int> m_NamedType { get; set; }
    public int m_CharaID { get; set; }
    public List<int> m_LimitNamedType { get; set; }
    public int m_LimitFriendShipLv { get; set; }
    public int m_PresentGemNum { get; set; }
    public int m_PresentMessageID { get; set; }
}
public class advmotionlist
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<advmotionlist_Params> m_Params { get; set; }
}
public class advmotionlist_Params
{
    public string m_MotionID { get; set; }
    public List<advmoParams_Datas> m_Datas { get; set; }
}
public class advmoParams_Datas
{
    public int m_Action { get; set; }
    public float m_X { get; set; }
    public float m_Y { get; set; }
    public float m_Duration { get; set; }
    public int m_EaseType { get; set; }
    public int m_WaitEnd { get; set; }
}
public class advemotionlist
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<advemotionlist_Params> m_Params { get; set; }
}
public class advemotionlist_Params
{
    public string m_EmotionID { get; set; }
    public string m_EffectID { get; set; }
    public int m_DefaultPosition { get; set; }
    public int m_Loop { get; set; }
}
public class advcharavoicelabel
{
    public List<advcharavoice> m_Params { get; set; }
}
public class advcharavoice
{
    public int m_NamedType { get; set; }
    public string m_VoiceLabel { get; set; }
}
public class advtexttagarg
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<advtexttagarg_Params> m_Params { get; set; }
}
public class advtexttagarg_Params
{
    public string m_ReferenceName { get; set; }
    public int m_EnumID { get; set; }
}
public class adveffectlist
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<adveffectlist_Params> m_Params { get; set; }
}
public class adveffectlist_Params
{
    public string m_PackName { get; set; }
    public string m_EffectID { get; set; }
    public int m_InstanceMax { get; set; }
    public List<int> m_PlayFrames { get; set; }
    public List<string> m_CueIDs { get; set; }
}
public class efjsonanimclip
{
    [JsonProperty("0 AnimationClip Base")]
    public AnimBase Base { get; set; }
}
public class AnimBase
{
    [JsonProperty("1 string m_Name")]
    public string m_Name { get; set; }
    [JsonProperty("0 bool m_Legacy")]
    public bool m_Legacy { get; set; }
    [JsonProperty("0 bool m_Compressed")]
    public bool m_Compressed { get; set; }
    [JsonProperty("1 bool m_UseHighQualityCurve")]
    public bool m_UseHighQualityCurve { get; set; }
    [JsonProperty("0 vector m_RotationCurves")]
    public RotationCurves m_RotationCurves { get; set; }
    [JsonProperty("0 vector m_PositionCurves")]
    public PositionCurves m_PositionCurves { get; set; }
    [JsonProperty("0 vector m_ScaleCurves")]
    public ScaleCurves m_ScaleCurves { get; set; }
    [JsonProperty("0 float m_SampleRate")]
    public float m_SampleRate { get; set; }
    [JsonProperty("0 int m_WrapMode")]
    public int m_WrapMode { get; set; }
    [JsonProperty("0 AABB m_Bounds")]
    public AABBanimclip m_Bounds { get; set; }
}
public class RotationCurves
{
    [JsonProperty("1 Array Array")]
    public List<RotationCurvesArray> Array { get; set; }
}
public class RotationCurvesArray
{
    [JsonProperty("0 QuaternionCurve data")]
    public QuaternionCurve data { get; set; }
}
public class QuaternionCurve
{
    [JsonProperty("0 AnimationCurve curve")]
    public AnimationCurve4Emo curve { get; set; }
    [JsonProperty("1 string path")]
    public string path { get; set; }
}
public class AnimationCurve4Emo
{
    [JsonProperty("0 vector m_Curve")]
    public Curve4 m_Curve { get; set; }
    [JsonProperty("0 int m_PreInfinity")]
    public int m_PreInfinity { get; set; }
    [JsonProperty("0 int m_PostInfinity")]
    public int m_PostInfinity { get; set; }
    [JsonProperty("0 int m_RotationOrder")]
    public int m_RotationOrder { get; set; }
}
public class Curve4
{
    [JsonProperty("1 Array Array")]
    public List<Curve4Array> Array { get; set; }
}
public class Curve4Array
{
    [JsonProperty("0 Keyframe data")]
    public Keyframe4Emo data { get; set; }
}
public class Keyframe4Emo
{
    [JsonProperty("0 float time")]
    public float time { get; set; }
    [JsonProperty("0 Quaternionf value")]
    public Quaternionf value { get; set; }
    [JsonProperty("0 Quaternionf inSlope")]
    public Quaternionf inSlope { get; set; }
    [JsonProperty("0 Quaternionf outSlope")]
    public Quaternionf outSlope { get; set; }
    [JsonProperty("0 int weightedMode")]
    public int weightedMode { get; set; }
    [JsonProperty("0 Quaternionf inWeight")]
    public Quaternionf inWeight { get; set; }
    [JsonProperty("0 Quaternionf outWeight")]
    public Quaternionf outWeight { get; set; }
}
public class Quaternionf
{
    [JsonProperty("0 float x")]
    public float x { get; set; }
    [JsonProperty("0 float y")]
    public float y { get; set; }
    [JsonProperty("0 float z")]
    public float z { get; set; }
    [JsonProperty("0 float w")]
    public float w { get; set; }
}
public class PositionCurves
{
    [JsonProperty("1 Array Array")]
    public List<PositionCurvesArray> Array { get; set; }
}
public class PositionCurvesArray
{
    [JsonProperty("0 Vector3Curve data")]
    public Vector3Curve data { get; set; }
}
public class Vector3Curve
{
    [JsonProperty("0 AnimationCurve curve")]
    public AnimationCurve3Emo curve { get; set; }
    [JsonProperty("1 string path")]
    public string path { get; set; }
}
public class AnimationCurve3Emo
{
    [JsonProperty("0 vector m_Curve")]
    public Curve3 m_Curve { get; set; }
    [JsonProperty("0 int m_PreInfinity")]
    public int m_PreInfinity { get; set; }
    [JsonProperty("0 int m_PostInfinity")]
    public int m_PostInfinity { get; set; }
    [JsonProperty("0 int m_RotationOrder")]
    public int m_RotationOrder { get; set; }
}
public class Curve3
{
    [JsonProperty("1 Array Array")]
    public List<Curve3Array> Array { get; set; }
}
public class Curve3Array
{
    [JsonProperty("0 Keyframe data")]
    public Keyframe3Emo data { get; set; }
}
public class Keyframe3Emo
{
    [JsonProperty("0 float time")]
    public float time { get; set; }
    [JsonProperty("0 Vector3f value")]
    public Vector3f value { get; set; }
    [JsonProperty("0 Vector3f inSlope")]
    public Vector3f inSlope { get; set; }
    [JsonProperty("0 Vector3f outSlope")]
    public Vector3f outSlope { get; set; }
    [JsonProperty("0 int weightedMode")]
    public int weightedMode { get; set; }
    [JsonProperty("0 Vector3f inWeight")]
    public Vector3f inWeight { get; set; }
    [JsonProperty("0 Vector3f outWeight")]
    public Vector3f outWeight { get; set; }
}
public class Vector3f
{
    [JsonProperty("0 float x")]
    public float x { get; set; }
    [JsonProperty("0 float y")]
    public float y { get; set; }
    [JsonProperty("0 float z")]
    public float z { get; set; }
}
public class ScaleCurves
{
    [JsonProperty("1 Array Array")]
    public List<ScaleCurvesArray> Array { get; set; }
}
public class ScaleCurvesArray
{
    [JsonProperty("0 Vector3Curve data")]
    public Vector3Curve data { get; set; }
}
public class AABBanimclip
{
    [JsonProperty("0 Vector3f m_Center")]
    public Vector3f m_Center { get; set; }
    [JsonProperty("0 Vector3f m_Extent")]
    public Vector3f m_Extent { get; set; }
}
public class MsbHandlerJson
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public List<MsbObjectHandler> m_MsbObjectHandlerArray { get; set; }
    public List<MsbMaterialHandler> m_MsbMaterialHandlerArray { get; set; }
    public List<MsbParticleEmitter> m_MsbParticleEmitterArray { get; set; }
}
public class MsbObjectHandler
{
    public string m_Name { get; set; }
    public int m_RefID { get; set; }
    public int m_HieIndex { get; set; }
    public int m_BoundingReferHieIndex { get; set; }
    public MsbObjectHandlerSrc m_Src { get; set; }
}
public class MsbObjectHandlerSrc
{
    public MeshColor m_MeshColor { get; set; }
    public float m_HDRFactor { get; set; }
    public int m_eRenderStage { get; set; }
    public int m_RenderOrder { get; set; }
    public int m_eBillboardType { get; set; }
    public int m_bVisibility { get; set; }
    public int m_bHalfVertexColor { get; set; }
    public int m_bFogEnable { get; set; }
    public float m_OutlineWidth { get; set; }
    public float m_OutlineDepthOffset { get; set; }
    public MeshColor m_OutlineColor { get; set; }
    public int m_OutlineType { get; set; }
}
public class MeshColor
{
    public float r { get; set; }
    public float g { get; set; }
    public float b { get; set; }
    public float a { get; set; }
}
public class MsbMaterialHandler
{
    public string m_Name { get; set; }
    public int m_RefID { get; set; }
    public MsbMaterialHandlerSrc m_Src { get; set; }
}
public class MsbMaterialHandlerSrc
{
    public MeshColor m_Diffuse { get; set; }
    public int m_BlendMode { get; set; }
    public List<MsbTexture> m_Texture { get; set; }
    public int m_OutlineBlendMode { get; set; }
    public float m_AlphaTestRefValue { get; set; }
}
public class MsbTexture
{
    public string m_Name { get; set; }
    public int m_eType { get; set; }
    public int m_Layer { get; set; }
    public xy m_CoverageUV { get; set; }
    public xy m_TranslationUV { get; set; }
    public xy m_OffsetUV { get; set; }
    public float m_RotateUV { get; set; }
    public int m_LayerBlendMode { get; set; }
    public int m_LayerBlendModeAlpha { get; set; }
}
public class xy
{
    public float x { get; set; }
    public float y { get; set; }
}
public class MsbParticleEmitter
{
    public class_GameObject m_ParticleEmitter { get; set; }
    public MsbMaterialHandler m_MsbMaterialHandler { get; set; }
    public class_GameObject m_ParentRenderer { get; set; }
}
public class MeigeAnimClipHolderJson
{
    public class_GameObject m_GameObject { get; set; }
    public int m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public class_GameObject m_UnityAnimClip { get; set; }
    public MeigeAnimClip m_MeigeAnimClip { get; set; }
}
public class MeigeAnimClip
{
    public string m_Name { get; set; }
    public int m_NumOfKeyframe { get; set; }
    public int m_BaseFPS { get; set; }
    public float m_AnimTimeBySec { get; set; }
    public List<AnimNodeHandler> m_AnimNodeHandlerArray { get; set; }
}
public class AnimNodeHandler
{
    public Target m_Target { get; set; }
    public List<Curve> m_Curves { get; set; }
}
public class Target
{
    public int m_TargetType { get; set; }
    public string m_TargetName { get; set; }
    public int m_RefID { get; set; }
    public int m_Param0 { get; set; }
    public int m_Param1 { get; set; }
    public int m_Param2 { get; set; }
}
public class Curve
{
    public List<ComponentCurve> m_ComponentCurves { get; set; }
}
public class ComponentCurve
{
    public List<KeyData> m_KeyDatas { get; set; }
}
public class KeyData
{
    public int m_CtrlType { get; set; }
    public float m_Frame { get; set; }
    public float m_Value { get; set; }
    public float m_LeftDerivative { get; set; }
    public float m_RightDerivative { get; set; }
}
public class MeigeParticleEmitterJson
{
    public class_GameObject m_GameObject { get; set; }
    public bool m_Enabled { get; set; }
    public class_GameObject m_Script { get; set; }
    public string m_Name { get; set; }
    public int m_isActive { get; set; }
    public List<int> m_Locators { get; set; }
    public RuleJson m_Rule { get; set; }
    public class_GameObject m_Material { get; set; }
    public Vector3 m_offsetRot { get; set; }
}
public class RuleJson
{
    public int m_particleNum { get; set; }
    public particleTypeParam m_particleTypeParam { get; set; }
    public int m_particleType { get; set; }
    public emitionParam m_emitionParam { get; set; }
    public int m_emitionType { get; set; }
    public Rect m_uvRect_TopBlock { get; set; }
    public int m_uvBlockNum { get; set; }
    public int m_LifeScaleType { get; set; }
    public RangeJson m_lifeScaleRange { get; set; }
    public RangeJson m_speedRange { get; set; }
    public Vector3 m_gravityDir { get; set; }
    public RangeJson m_gravityForceRange { get; set; }
    public int m_lifeSpanType { get; set; }
    public int m_lifeSpanAlpha { get; set; }
    public LifeSpanParam m_LifeSpanParam { get; set; }
    public int m_collisionType { get; set; }
    public collisionParam m_collisionParam { get; set; }
    public float m_incidentNumberPerSec { get; set; }
    public float m_incidentRandomLevel { get; set; }
    public float m_HDR_Factor { get; set; }
    public float m_AlphaScale { get; set; }
    public float m_frameSpeedScale { get; set; }
    public int m_usingLight { get; set; }
    public int m_isLocalTrans { get; set; }
    public int m_isRandomEmitDir { get; set; }
    public int m_UsingAccelerationFlg { get; set; }
    public AccelerationComponentJson m_AccelerationComponent { get; set; }
    public int m_UsingRotationFlg { get; set; }
    public RotationComponentJson m_RotationComponent { get; set; }
    public int m_UsingUVAnimationFlg { get; set; }
    public UVAnimationComponentJson m_UVAnimationComponent { get; set; }
    public int m_UsingColorCurveFlg { get; set; }
    public ColorCurveComponentJson m_ColorCurveComponent { get; set; }
    public int m_UsingTailFlg { get; set; }
    public TailComponentJson m_TailComponent { get; set; }
    public int m_UsingBlinkFlg { get; set; }
    public BlinkComponentJson m_BlinkComponent { get; set; }
    public int m_UsingPathMoveFlg { get; set; }
    public PathMoveComponentJson m_PathMoveComponent { get; set; }
}
public class RangeJson
{
    public ValueJson m_Min { get; set; }
    public ValueJson m_Max { get; set; }
    public float Random()
    {
        return UnityEngine.Random.Range(m_Min.m_Value, m_Max.m_Value);
    }
    public float Lerp(float x)
    {
        return m_Min.m_Value + x * (m_Max.m_Value - m_Min.m_Value);
    }
}
public class ValueJson
{
    public float m_Value { get; set; }
}
public class particleTypeParam
{
    public billboard m_billboard { get; set; }
    public RangeSize m_point { get; set; }
    public line m_line { get; set; }
    public polyLine m_polyLine { get; set; }
    public RangeWidthHeight m_confetti { get; set; }
    public ribbon m_ribbon { get; set; }
}
public class billboard
{
    public RangeJson m_widthRange { get; set; }
    public RangeJson m_heightRange { get; set; }
    public int m_RotateType { get; set; }
}
public class RangeSize
{
    public RangeJson m_sizeRange { get; set; }
}
public class line
{
    public float m_width { get; set; }
    public int m_jointNum { get; set; }
    public int m_HistoryPointNum { get; set; }
}
public class polyLine
{
    public RangeJson m_topWidthRange { get; set; }
    public RangeJson m_endWidthRange { get; set; }
    public int m_jointNum { get; set; }
    public int m_HistoryPointNum { get; set; }
}
public class ribbon
{
    public RangeJson m_topWidthRange { get; set; }
    public RangeJson m_endWidthRange { get; set; }
    public int m_jointNum { get; set; }
    public int m_HistoryPointNum { get; set; }
}
public class emitionParam
{
    public RangeAngle m_point { get; set; }
    public RangeWidthHeightDepth m_box { get; set; }
    public RangeWidthHeight m_planeQuad { get; set; }
    public RangeRadius m_planeCircle { get; set; }
    public RangeAngleRadius m_sphere { get; set; }
    public torus m_torus { get; set; }
    public RangeRadiusHeight m_cylinder { get; set; }
}
public class RangeAngle
{
    public RangeJson m_angleRange { get; set; }
}
public class RangeWidthHeightDepth
{
    public RangeJson m_widthRange { get; set; }
    public RangeJson m_heightRange { get; set; }
    public RangeJson m_depthRange { get; set; }
}
public class RangeWidthHeight
{
    public RangeJson m_widthRange { get; set; }
    public RangeJson m_heightRange { get; set; }
}
public class RangeRadius
{
    public RangeJson m_radiusRange { get; set; }
}
public class RangeAngleRadius
{
    public RangeJson m_angleRange { get; set; }
    public RangeJson m_radiusRange { get; set; }
}
public class torus
{
    public RangeJson m_angleRange { get; set; }
    public float m_bigRadiusRange { get; set; }
    public RangeJson m_smallRadiusRange { get; set; }
}
public class RangeRadiusHeight
{
    public RangeJson m_RadiusRange { get; set; }
    public RangeJson m_HeightRange { get; set; }
}
public class LifeSpanParam
{
    public TimeJson m_Time { get; set; }
    public Distance m_Distance { get; set; }
    public Height m_Height { get; set; }
}
public class TimeJson
{
    public RangeJson m_lifeSpanSecRange { get; set; }
}
public class Distance
{
    public RangeJson m_lifeSpanDistanceMaxRange { get; set; }
}
public class Height
{
    public RangeJson m_lifeSpanHeightRange { get; set; }
}
public class collisionParam
{
    public height m_height { get; set; }
    public collision m_collision { get; set; }
}
public class height
{
    public float m_height { get; set; }
    public float m_reflectionCoefficient { get; set; }
    public float m_frictionCoefficient { get; set; }
    public int m_isLocalHeight { get; set; }
}
public class collision
{
    public float m_reflectionCoefficient { get; set; }
}
public class AccelerationComponentJson
{
    public RangeJson m_accelerationRange { get; set; }
    public RangeJson m_dragForceRange { get; set; }
}
public class RotationComponentJson
{
    public RangeJson m_rotSpeedRange { get; set; }
    public RangeJson m_rotAccelerationRange { get; set; }
    public RangeJson m_rotDragForceRange { get; set; }
    public RangeJson m_rotAnchorOffsetRange { get; set; }
    public RangeJson m_rotRange { get; set; }
}
public class UVAnimationComponentJson
{
    public int m_uvAnimeType { get; set; }
    public RangeJson m_switchBlockSecRange { get; set; }
    public int m_randomStartBlockFlg { get; set; }
}
public class ColorCurveComponentJson
{
    public List<pColorCurveArray> m_pColorCurveArray { get; set; }
    public int m_colorCurveNum { get; set; }
}
public class pColorCurveArray
{
    public List<ValueArray> m_Value { get; set; }
    public List<int> m_Point { get; set; }
}
public class ValueArray
{
    public Color m_Value { get; set; }
}
public class TailComponentJson
{
    public Rect m_tailUVRect { get; set; }
}
public class BlinkComponentJson
{
    public RangeJson m_blinkSpanSecRange { get; set; }
}
public class PathMoveComponentJson
{
    public RangeJson m_startFocusRadiusRange { get; set; }
    public RangeJson m_endFocusRadiusRange { get; set; }
    public List<RangeJson> m_FocusRadiusRange { get; set; }
}
public class PrimPolyLine
{
    public Line[] lines;
    public Vector3[] positions;
    public float[] widths;
    public float[] UWidths;
    public Vector2[] UVs;
    public Color[] colors;
    public int lineNum;
    public int pointNum;
}
public class PrimLineArray : MonoBehaviour
{
    public Vector3[] vertices;
    public Vector2[] uvs;
    public Color[] colors;
    public int[] triangles;
}
public class ParticleObjectParams : MonoBehaviour
{
    public Transform m_thisTransform;
    public Matrix4x4 m_Matrix;
    public Matrix4x4 m_OldMatrix;
    public List<PrimPolyLine> lines;
}
public class ParticleUnitParams : MonoBehaviour
{
    public Vector3 m_birthPos;
    public Vector3 m_pos;
    public Vector3 m_offset;
    public float m_scale;
    public float m_lifeScaleMax;
    public Vector3 m_velocity;
    public Vector3 m_gravityForce;
    public Rect m_uvRect;
    public Color m_color;
    public int m_particleType;
    public int m_lifeSpanType;
    public float m_lifeSpanRate;
    public float[] m_lifeSpanParam = new float[2];
    public float m_lifeSpanFadeAlphaRate;
    public int m_Index;
    public int m_aliveCount;
    public Billboard m_billboard;
    public Point m_point;
    public Line m_line;
    public PolyLine m_polyLine;
    public Confetti m_confetti;
    public Ribbon m_ribbon;
    public AccelerationComponent m_AccelerationComponent;
    public RotationComponent m_RotationComponent;
    public UVAnimationComponent m_UVAnimationComponent;
    public ColorCurveComponent m_ColorCurveComponent;
    public TailComponent m_TailComponent;
    public BlinkComponent m_BlinkComponent;
    public PathMoveComponent m_PathMoveComponent;
    public bool m_activeFlg;
    public MeshRenderer meshRenderer;
    public float lastUpdateTime;
}
public class Billboard
{
    public float m_width;
    public float m_height;
}
public class Point
{
    public float m_size;
}
public class Line
{
    public short m_jointNum;
    public short m_HistoryPointNum;
    public float m_width;
    public float m_width2;
    public Vector3[] m_pPos;
}

public class PolyLine
{
    public short m_jointNum;
    public short m_HistoryPointNum;
    public float m_topWidth;
    public float m_endWidth;
    public Vector3[] m_pPos;
}

public class Confetti
{
    public float m_width;
    public float m_height;
}

public class Ribbon
{
    public short m_jointNum;
    public short m_HistoryPointNum;
    public float m_topWidth;
    public float m_endWidth;
    public Vector3[] m_pPos;
    public Vector3[] m_pVelocity;
}
public class AccelerationComponent
{
    public float m_acceleration;
    public float m_dragForce;
}

public class RotationComponent
{
    public Vector3 m_rot;
    public Vector3 m_rotAnchorOffset;
    public Vector3 m_rotVelocity;
    public Vector3 m_rotAcceleration;
    public float m_rotDragForce;
}

public class UVAnimationComponent
{
    public int m_nowBlock;
    public float m_switchSec;
    public float m_switchSecWork;
}

public class ColorCurveComponent
{
    public RangeValueColor m_pColorCurve;
}
public class RangeValueColor
{
    private List<Color> _rgbas = new List<Color>();
    public int Length
    {
        get => _rgbas.Count;
    }
    public Color this[int index]
    {
        get => _rgbas[index];
        set => _rgbas[index] = value;
    }
    public RangeValueColor(params Color[] values)
    {
        _rgbas = new List<Color>(values);
    }
    public Color Lerp(float t)
    {
        float scaled = t * (_rgbas.Count - 1);
        int i0 = Mathf.FloorToInt(scaled);
        int i1 = Mathf.Min(i0 + 1, _rgbas.Count - 1);

        float localT = scaled - i0;
        float r = Mathf.Lerp(_rgbas[i0].r, _rgbas[i1].r, localT);
        float g = Mathf.Lerp(_rgbas[i0].g, _rgbas[i1].g, localT);
        float b = Mathf.Lerp(_rgbas[i0].b, _rgbas[i1].b, localT);
        float a = Mathf.Lerp(_rgbas[i0].a, _rgbas[i1].a, localT);
        return new Color(r, g, b, a);
    }
}
public class TailComponent
{
    public Vector3[] m_pTailPos;
    public Vector3 m_TopPos;
    public Rect m_tailUVRect;
    public float m_width;
}

public class BlinkComponent
{
    public float m_blinkRate;
    public float m_blinkSpeed;
}

public class PathMoveComponent
{
    public Vector3[] m_offsetPos;
}

public class standpics
{
    public List<standpics_Params> Params { get; set; }
}
public class standpics_Params
{
    public string Name { get; set; }
    public List<string> Files { get; set; }
}
public class voices
{
    public List<voices_Params> Params { get; set; }
}
public class voices_Params
{
    public string Name { get; set; }
    public List<voicelabels> VoiceLabels { get; set; }
}
public class voicelabels
{
    public string VoiceLabel { get; set; }
    public List<string> Choices { get; set; }
}
public class BGProperties : MonoBehaviour
{
    public uint ID;
    public Vector2 Position;
    public float Scale;
    public Vector2 ShakeOffset;
}
public class SpriteProperties : MonoBehaviour
{
    public uint ID;
    public Vector2 pos;
    public Vector2 scale;
    public Color color;
    public float fade;
}
public class CharaProperties
{
    public float Fade;
    public float Transparency;
    public int FaceID;
    public int PoseID;
    public Vector2 Position;
    public float Scale;
    public Vector2 MotOffset;
    public Vector2 ShakeOffset;
    public float Angle;
    public Vector2 RotateCenter;
    public float HDRFactor;
}
public class player : MonoBehaviour
{
#if UNITY_WEBGL
    [DllImport("__Internal")]
    private static extern void SetWebTitle(string title);
    [DllImport("__Internal")]
    public static extern string GetPlaylistFromLocalStorage();

    [DllImport("__Internal")]
    public static extern void ClearPlaylistInLocalStorage();
#else
    [DllImport("user32.dll")]
    private static extern bool SetWindowText(System.IntPtr hWnd, string text);
    [DllImport("user32.dll")]
    private static extern System.IntPtr GetActiveWindow();
#endif
    public string host;
    public List<int> ADVIDs;
    public bool auto = false;
    public bool QuickPlay = false;
    public int Attempt = 100;
    public float AttemptDelay = 0.1f;
    public float TimeScale = 1;
    public bool DebugMode = false;
    public bool useCustomJson = false;
    public string globalFont;
    public string audioMode = "ogg";
    public float BGMVolume = 1f;
    public float SEVolume = 1f;
    public float VoiceVolume = 1f;
    public bool enableParticle = false;
    private bool netError = false;
    private Font font;
    private int ADVID;
    private int ADVIndex;
    private bool autoClick = false;
    private bool PreloadEnd = false;
    private List<Coroutine> autoSkipCoroutine = new List<Coroutine>();
    private advlist advList;
    private advmotionlist advMotionList;
    private advemotionlist advEmotionList;
    private advcharacterlist advCharacterList;
    private Dictionary<int, comicscript> comicScripts = new Dictionary<int, comicscript>();
    private Dictionary<int, comicspritelist> comicSpriteLists = new Dictionary<int, comicspritelist>();
    private Dictionary<int, advscript> advScripts = new Dictionary<int, advscript>();
    private Dictionary<int, advscripttext> advScriptTexts = new Dictionary<int, advscripttext>();
    public comicscript comicScript;
    public comicspritelist comicSpriteList;
    private advscript advScript;
    private advscripttext advScriptText;
    private advcharavoicelabel advCharaVoiceLabel;
    private advtexttagarg advTextTagArg;
    private adveffectlist advEffectList;
    private advlist advCustomList;
    private GameObject canvasObj;
    private Canvas canvas;
    private GameObject effectCanvasObj;
    private Canvas effectCanvas;
    private GameObject textCanvasObj;
    private Canvas textCanvas;
    private GameObject renderTextureObj;
    private GameObject camerasObj;
    private List<Camera> cameras = new List<Camera>();
    private GameObject particleObj;
    private bool hasCharaName = false;
    private SpriteRenderer talkerRenderer;
    private SpriteRenderer autoLabelRenderer;
    private SpriteRenderer autoIconRenderer;
    private SpriteRenderer AUTORenderer;
    private standpics StandPics;
    private standpics Effects;
    private voices Voices;
    private GameObject Render;
    private RenderTexture renderTexture;
    private RenderTexture bgTexture;
    private GameObject bgPrimObj;
    private SpriteRenderer renderSpriteRenderer;
    private GameObject image;
    private SpriteRenderer imageSpriteRenderer;
    private GameObject Audios;
    private GameObject ADVAutoIcon;
    private GameObject ADVAutoLabelBG;
    private GameObject ADVPen;
    private GameObject ADVPenShadow;
    private Coroutine PenCoroutine;
    private Coroutine CanvasMoveCoroutine;
    private Dictionary<string, string> webText = new Dictionary<string, string>();
    private Dictionary<string, efjsonanimclip> webAnimClip = new Dictionary<string, efjsonanimclip>();
    private Dictionary<string, MsbHandlerJson> webMsbHandler = new Dictionary<string, MsbHandlerJson>();
    private Dictionary<string, MeigeAnimClipHolderJson> webMeigeAnimClipHolder = new Dictionary<string, MeigeAnimClipHolderJson>();
    private Dictionary<string, MeigeParticleEmitterJson> webMeigeParticleEmitter = new Dictionary<string, MeigeParticleEmitterJson>();
    private Dictionary<string, Texture2D> webTexture = new Dictionary<string, Texture2D>();
    private Dictionary<string, AudioClip> webAudio = new Dictionary<string, AudioClip>();
    private Dictionary<string, AssetBundle> webAssetBundle = new Dictionary<string, AssetBundle>();
    private Dictionary<string, GameObject> webGameObject = new Dictionary<string, GameObject>();
    private Dictionary<string, IEnumerator> LoadingIEnumerators = new Dictionary<string, IEnumerator>();
    private List<string> LoadedPacks = new List<string>();
    private Dictionary<int, string[]> Jsons = new Dictionary<int, string[]>();
    private List<string> LoadedAssets = new List<string>();
    private Dictionary<string, float> lineSpacing = new Dictionary<string, float> { { "ja", 0.8f }, { "zh", 1.2f } };
    private Dictionary<Vector4, Mesh> meshCache = new Dictionary<Vector4, Mesh>();
    private Dictionary<string, GameObject> gameObjectCache = new Dictionary<string, GameObject>();

    private GameObject FindCached(string name)
    {
        if (gameObjectCache.TryGetValue(name, out GameObject go) && go != null)
        {
            return go;
        }
        go = GameObject.Find(name);
        if (go != null) { gameObjectCache[name] = go; }
        return go;
    }

    private void CacheGameObject(string name, GameObject go)
    {
        if (go != null) { gameObjectCache[name] = go; }
    }

    private void RemoveCachedGameObject(string name)
    {
        gameObjectCache.Remove(name);
    }
    private Dictionary<string, advcharacterlist_Params> charaParamsLookup = new Dictionary<string, advcharacterlist_Params>();
    private Dictionary<string, advemotionlist_Params> emotionLookup = new Dictionary<string, advemotionlist_Params>();
    private Dictionary<string, adveffectlist_Params> effectLookup = new Dictionary<string, adveffectlist_Params>();
    private static readonly int _UVRect = Shader.PropertyToID("_UVRect");
    private static readonly int _MeshColor = Shader.PropertyToID("_MeshColor");
    private static readonly int _MatColor = Shader.PropertyToID("_MatColor");
    private static readonly int _MainTex = Shader.PropertyToID("_MainTex");
    private static readonly int _AlphaTex = Shader.PropertyToID("_AlphaTex");
    private static readonly int _HDRFactor = Shader.PropertyToID("_HDRFactor");
    private static readonly int _BlendSrc = Shader.PropertyToID("_BlendSrc");
    private static readonly int _BlendDst = Shader.PropertyToID("_BlendDst");
    private static readonly int _Warp = Shader.PropertyToID("_Warp");
    private static readonly int _ProgressRate = Shader.PropertyToID("_ProgressRate");
    private static readonly int _NoiseTextureParam = Shader.PropertyToID("_NoiseTextureParam");
    private static readonly int _Level = Shader.PropertyToID("_Level");
    private static readonly int _DistortionLevel = Shader.PropertyToID("_DistortionLevel");
    private static readonly int _EnableDistortion = Shader.PropertyToID("_EnableDistortion");
    private static readonly int _ColorBlend = Shader.PropertyToID("_ColorBlend");
    private static readonly int _EnableColorBlend = Shader.PropertyToID("_EnableColorBlend");
    private Dictionary<GameObject, ParticleObjectParams> particleObjectParamsCache = new Dictionary<GameObject, ParticleObjectParams>();
    private Dictionary<GameObject, ParticleUnitParams> particleUnitParamsCache = new Dictionary<GameObject, ParticleUnitParams>();
    private Transform cachedMainCameraTransform;
    private Vector3[] polyLineVerts;
    private Vector2[] polyLineUVs;
    private Color[] polyLineCols;
    private int[] polyLineTris;

    private void BuildLookupDictionaries()
    {
        charaParamsLookup.Clear();
        if (advCharacterList?.m_Params != null)
        {
            foreach (var p in advCharacterList.m_Params)
            {
                charaParamsLookup[p.m_ADVCharaID] = p;
            }
        }
        emotionLookup.Clear();
        if (advEmotionList?.m_Params != null)
        {
            foreach (var p in advEmotionList.m_Params)
            {
                emotionLookup[p.m_EmotionID] = p;
            }
        }
        effectLookup.Clear();
        if (advEffectList?.m_Params != null)
        {
            foreach (var p in advEffectList.m_Params)
            {
                effectLookup[p.m_EffectID] = p;
            }
        }
    }

    private IEnumerator DownloadText(string name, string url)
    {
        webText.Add(name, null);
        int attempt = 0;
        while (attempt < Attempt)
        {
            UnityWebRequest request = UnityWebRequest.Get(url);
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string json = request.downloadHandler.text;
                webText[name] = json;
                if (name.EndsWith("@Take 001.json")){
                    json = json.Replace("+Infinity", "10000").Replace("-Infinity", "-10000");
                    webAnimClip[name] = JsonConvert.DeserializeObject<efjsonanimclip>(json);
                }
                if (name.EndsWith("MsbHandler.json"))
                {
                    webMsbHandler[name] = JsonConvert.DeserializeObject<MsbHandlerJson>(json);
                }
                if (name.EndsWith("MeigeAnimClipHolder.json"))
                {
                    webMeigeAnimClipHolder[name] = JsonConvert.DeserializeObject<MeigeAnimClipHolderJson>(json);
                }
                if (name.Contains("MeigeParticleEmitter"))
                {
                    webMeigeParticleEmitter[name] = JsonConvert.DeserializeObject<MeigeParticleEmitterJson>(json);
                }
                LoadedAssets.Add(name);
                break;
            }
            else
            {
                attempt++;
                if (attempt == Attempt)
                {
                    netError = true;
                    break;
                }
                yield return new WaitForSeconds(AttemptDelay);
            }
        }
    }
    private IEnumerator DownloadTexture(string name, string url)
    {
        webTexture.Add(name, null);
        int attempt = 0;
        while (attempt < Attempt)
        {
            UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                Texture2D texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
                webTexture[name] = texture;
                LoadedAssets.Add(name);
                break;
            }
            else
            {
                attempt++;
                if (attempt == Attempt)
                {
                    netError = true;
                    break;
                }
                yield return new WaitForSeconds(AttemptDelay);
            }
        }
    }
    private IEnumerator DownloadAudio(string name, string url, string type)
    {
        webAudio.Add(name, null);
        int attempt = 0;
        while (attempt < Attempt)
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            UnityWebRequest request = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.AUDIOQUEUE);
#else
            UnityWebRequest request = UnityWebRequestMultimedia.GetAudioClip(url, type == "ogg" ? AudioType.OGGVORBIS : AudioType.WAV);
#endif
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                AudioClip audioClip = DownloadHandlerAudioClip.GetContent(request);
                webAudio[name] = audioClip;
                LoadedAssets.Add(name);
                break;
            }
            else
            {
                attempt++;
                if (attempt == Attempt)
                {
                    netError = true;
                    break;
                }
                yield return new WaitForSeconds(AttemptDelay);
            }
        }
    }
    private IEnumerator DownloadAssetBundle(string name, string url)
    {
        webAssetBundle.Add(name, null);
        int attempt = 0;
        while (attempt < Attempt)
        {
            UnityWebRequest request = UnityWebRequest.Get(url);
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                AssetBundleCreateRequest bundleRequest = AssetBundle.LoadFromMemoryAsync(request.downloadHandler.data);
                yield return bundleRequest;
                webAssetBundle[name] = bundleRequest.assetBundle;
                LoadedAssets.Add(name);
                break;
            }
            else
            {
                attempt++;
                if (attempt == Attempt)
                {
                    netError = true;
                    break;
                }
                yield return new WaitForSeconds(AttemptDelay);
            }
        }
    }
    private IEnumerator GetGameObject(string name, string ABname)
    {
        while (!webAssetBundle.ContainsKey(ABname))
        {
            yield return null;
        }
        while (webAssetBundle[ABname] == null)
        {
            yield return null;
        }
        AssetBundle bundle = webAssetBundle[ABname];
        AssetBundleRequest request = bundle.LoadAssetAsync<GameObject>(name);
        yield return request;
        webGameObject.Add(name, request.asset as GameObject);
    }
    private void DownloadPackStandPic(string name)
    {
        if (!LoadedPacks.Contains(name))
        {
            LoadedPacks.Add(name);
            foreach (string file in StandPics.Params.First(param => param.Name == name).Files)
            {
                LoadingIEnumerators.Add(name + "_" + file, DownloadTexture(name + "_" + file, $"{host}/standpic/{name}_{file}.png"));
            }
        }
    }
    private void DownloadPackEffect(string name)
    {
        if (!LoadedPacks.Contains(name))
        {
            LoadedPacks.Add(name);
            foreach (string file in Effects.Params.First(param => param.Name == name).Files)
            {
                if (file.EndsWith(".json"))
                {
                    LoadingIEnumerators.Add(name + @"\" + file, DownloadText(name + @"\" + file, $"{host}/ef_adv/{name}/{file}"));
                }
                else
                {
                    LoadingIEnumerators.Add(name + @"\" + file, DownloadTexture(name + @"\" + file, $"{host}/ef_adv/{name}/{file}"));
                }
            }
            string PackName = advEffectList.m_Params.First(param => param.m_EffectID == name).m_PackName;
            if (PackName == "")
            {
                LoadingIEnumerators.Add(name, DownloadAssetBundle(name, $"{host}/ef_adv/ab/{name.ToLower()}.assetbundle"));
                foreach (string CueID in advEffectList.m_Params.First(param => param.m_EffectID == name).m_CueIDs)
                {
                    if (!LoadingIEnumerators.ContainsKey(CueID))
                    {
                        LoadingIEnumerators.Add(CueID, DownloadAudio(CueID, $"{host}/se/{CueID}.wav", "wav"));
                    }
                }
                StartCoroutine(GetGameObject(name, name));
            }
            else
            {
                if (!LoadingIEnumerators.ContainsKey(PackName))
                {
                    LoadingIEnumerators.Add(PackName, DownloadAssetBundle(PackName, $"{host}/ef_adv/ab/{PackName.ToLower()}.assetbundle"));
                }
                StartCoroutine(GetGameObject(name, PackName));
            }
        }
    }
    private void DownloadPackVoice(string name, string voicelabel)
    {
        if (!LoadedPacks.Contains(name + "_" + voicelabel))
        {
            LoadedPacks.Add(name + "_" + voicelabel);
            if (Voices.Params.First(param => param.Name == name).VoiceLabels.FirstOrDefault(param => param.VoiceLabel == voicelabel) == null) { return; }
            foreach (string file in Voices.Params.First(param => param.Name == name).VoiceLabels.First(param => param.VoiceLabel == voicelabel).Choices)
            {
                LoadingIEnumerators.Add(name + @"\voice_" + voicelabel + "_" + file, DownloadAudio(name + @"\voice_" + voicelabel + "_" + file, $"{host}/voice/{name}/voice_{voicelabel}_{file}.{audioMode}", audioMode));
            }
        }
    }
    private IEnumerator DownloadJson(string url, int ADVID, int index)
    {
        int attempt = 0;
        while (attempt < Attempt)
        {
            UnityWebRequest request = UnityWebRequest.Get(url);
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string json = request.downloadHandler.text;
                Jsons[ADVID][index] = json;
                break;
            }
            else
            {
                attempt++;
                if (attempt == Attempt)
                {
                    netError = true;
                    break;
                }
                yield return new WaitForSeconds(AttemptDelay);
            }
        }
    }
    private IEnumerator LoadJson(int ADVID)
    {
        advlist_Params advlistParams = advList.m_Params.First(param => param.m_AdvID == ADVID);
        string advcategory = ADVCategory[advlistParams.m_Category];
        if (Jsons.ContainsKey(ADVID))
        {
            yield break;
        }
        if (advlistParams.m_ScriptName != "")
        {
            string filePath = $"{host}/advscript/{advcategory}/ADVScript_{advcategory}_{advlistParams.m_ScriptName}.json";
            Jsons.Add(ADVID, new string[2]);
            Coroutine coroutine1 = StartCoroutine(DownloadJson(filePath, ADVID, 0));
            yield return coroutine1;
            advScript = JsonConvert.DeserializeObject<advscript>(Jsons[ADVID][0]);
            advScripts.Add(ADVID, advScript);
            //Debug.Log(advScript.m_Name);
            string textfilePath = $"{host}/advscript/{advcategory}/ADVScriptText_{advcategory}_{advlistParams.m_ScriptTextName}.json";
            Coroutine coroutine2 = StartCoroutine(DownloadJson(textfilePath, ADVID, 1));
            yield return coroutine2;
            advScriptText = JsonConvert.DeserializeObject<advscripttext>(Jsons[ADVID][1]);
            advScriptTexts.Add(ADVID, advScriptText);
            //Debug.Log(advScriptText.m_Name);
        }
        else
        {
            string scriptPath = $"{host}/comic/ComicScript_{advlistParams.m_ComicGroupName}.json";
            Jsons.Add(ADVID, new string[2]);
            Coroutine coroutine1 = StartCoroutine(DownloadJson(scriptPath, ADVID, 0));
            yield return coroutine1;
            comicScript = JsonConvert.DeserializeObject<comicscript>(Jsons[ADVID][0]);
            comicScripts.Add(ADVID, comicScript);
            //Debug.Log(comicScript.m_Name);
            string spriteListPath = $"{host}/comic/ComicSpriteList_{advlistParams.m_ComicGroupName}.json";
            Coroutine coroutine2 = StartCoroutine(DownloadJson(spriteListPath, ADVID, 1));
            yield return coroutine2;
            comicSpriteList = JsonConvert.DeserializeObject<comicspritelist>(Jsons[ADVID][1]);
            comicSpriteLists.Add(ADVID, comicSpriteList);
            //Debug.Log(comicSpriteList.m_Name);
        }
    }
    private IEnumerator Preload(int ADVID)
    {
        yield return StartCoroutine(LoadJson(ADVID));
        if (!advScripts.ContainsKey(ADVID))
        {
            yield break;
        }
        Dictionary<string, string> CharasExistPreLoad = new Dictionary<string, string>();
        string[] TargetsPreLoad = new string[5];
        foreach (class_FuncParam func in advScripts[ADVID].m_Params[0].FuncParam)
        {
            advcharacterlist_Params param;
            advscripttext_Params textparam;
            advemotionlist_Params emoParam;
            string charaName;
            switch (func.funcName)
            {
                case "BGVisible":
                    if (!LoadingIEnumerators.ContainsKey(func.m_value2))
                    {
                        LoadingIEnumerators.Add(func.m_value2, DownloadTexture(func.m_value2, $"{host}/bg/{func.m_value2}.png"));
                    }
                    break;
                case "CharaIn":
                    DownloadPackStandPic(GetCharaParams(func.m_value1).m_ResourceBaseName);
                    if (GetCharaParams(func.m_value1) != null)
                    {
                        CharasExistPreLoad[func.m_value1] = GetCharaParams(func.m_value1).m_DisplayName;
                    }
                    break;
                case "CharaInFade":
                    if (GetCharaParams(func.m_value1) != null)
                    {
                        CharasExistPreLoad[func.m_value1] = GetCharaParams(func.m_value1).m_DisplayName;
                    }
                    DownloadPackStandPic(GetCharaParams(func.m_value1).m_ResourceBaseName);
                    break;
                case "CharaInTarget":
                    foreach (string charaname in TargetsPreLoad)
                    {
                        if (GetCharaParams(charaname) != null)
                        {
                            CharasExistPreLoad[charaname] = GetCharaParams(charaname).m_DisplayName;
                        }
                    }
                    break;
                case "CharaOut":
                    CharasExistPreLoad.Remove(func.m_value1);
                    break;
                case "CharaOutAll":
                    CharasExistPreLoad = new Dictionary<string, string>();
                    break;
                case "CharaOutFade":
                    CharasExistPreLoad.Remove(func.m_value1);
                    break;
                case "CharaOutAllFade":
                    CharasExistPreLoad = new Dictionary<string, string>();
                    break;
                case "CharaOutTarget":
                    foreach (string charaname in TargetsPreLoad)
                    {
                        if (GetCharaParams(charaname) != null)
                        {
                            CharasExistPreLoad.Remove(charaname);
                        }
                    }
                    break;
                case "CharaPosition":
                    DownloadPackStandPic(GetCharaParams(func.m_value1).m_ResourceBaseName);
                    break;
                case "CharaMove":
                    DownloadPackStandPic(GetCharaParams(func.m_value1).m_ResourceBaseName);
                    break;
                case "CharaShot":
                    if (GetCharaParams(func.m_value1) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value1).m_ResourceBaseName);
                        CharasExistPreLoad[func.m_value1] = GetCharaParams(func.m_value1).m_DisplayName;
                    }
                    if (GetCharaParams(func.m_value2) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value2).m_ResourceBaseName);
                        CharasExistPreLoad[func.m_value2] = GetCharaParams(func.m_value2).m_DisplayName;
                    }
                    if (GetCharaParams(func.m_value3) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value3).m_ResourceBaseName);
                        CharasExistPreLoad[func.m_value3] = GetCharaParams(func.m_value3).m_DisplayName;
                    }
                    if (GetCharaParams(func.m_value4) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value4).m_ResourceBaseName);
                        CharasExistPreLoad[func.m_value4] = GetCharaParams(func.m_value4).m_DisplayName;
                    }
                    if (GetCharaParams(func.m_value5) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value5).m_ResourceBaseName);
                        CharasExistPreLoad[func.m_value5] = GetCharaParams(func.m_value5).m_DisplayName;
                    }
                    break;
                case "CharaShotFade":
                    if (GetCharaParams(func.m_value1) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value1).m_ResourceBaseName);
                        CharasExistPreLoad[func.m_value1] = GetCharaParams(func.m_value1).m_DisplayName;
                    }
                    if (GetCharaParams(func.m_value2) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value2).m_ResourceBaseName);
                        CharasExistPreLoad[func.m_value2] = GetCharaParams(func.m_value2).m_DisplayName;
                    }
                    if (GetCharaParams(func.m_value3) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value3).m_ResourceBaseName);
                        CharasExistPreLoad[func.m_value3] = GetCharaParams(func.m_value3).m_DisplayName;
                    }
                    if (GetCharaParams(func.m_value4) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value4).m_ResourceBaseName);
                        CharasExistPreLoad[func.m_value4] = GetCharaParams(func.m_value4).m_DisplayName;
                    }
                    if (GetCharaParams(func.m_value5) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value5).m_ResourceBaseName);
                        CharasExistPreLoad[func.m_value5] = GetCharaParams(func.m_value5).m_DisplayName;
                    }
                    break;
                case "SetTarget":
                    if (GetCharaParams(func.m_value1) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value1).m_ResourceBaseName);
                        TargetsPreLoad[0] = func.m_value1;
                    }
                    if (GetCharaParams(func.m_value2) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value2).m_ResourceBaseName);
                        TargetsPreLoad[1] = func.m_value2;
                    }
                    if (GetCharaParams(func.m_value3) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value3).m_ResourceBaseName);
                        TargetsPreLoad[2] = func.m_value3;
                    }
                    if (GetCharaParams(func.m_value4) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value4).m_ResourceBaseName);
                        TargetsPreLoad[3] = func.m_value4;
                    }
                    if (GetCharaParams(func.m_value5) != null)
                    {
                        DownloadPackStandPic(GetCharaParams(func.m_value5).m_ResourceBaseName);
                        TargetsPreLoad[4] = func.m_value5;
                    }
                    break;
                case "SpriteSet":
                    if (!LoadingIEnumerators.ContainsKey(func.m_value2))
                    {
                        LoadingIEnumerators.Add(func.m_value2, DownloadTexture(func.m_value2, $"{host}/sprite/{func.m_value2}.png"));
                    }
                    break;
                case "SetCaptionBGSprite":
                    if (func.m_value1 != "無し")
                    {
                        if (!LoadingIEnumerators.ContainsKey(func.m_value1))
                        {
                            LoadingIEnumerators.Add(func.m_value1, DownloadTexture(func.m_value1, $"{host}/sprite/{func.m_value1}.png"));
                        }
                    }
                    break;
                case "CharaEmotion":
                    emoParam = advEmotionList.m_Params.First(param => param.m_EmotionID == func.m_value2);
                    DownloadPackEffect(emoParam.m_EffectID);
                    break;
                case "CharaTalk":
                    textparam = advScriptText.m_Params[int.Parse(func.m_value1)];
                    charaName = textparam.m_charaName.IndexOf('$') == -1 ? textparam.m_charaName : textparam.m_charaName[(textparam.m_charaName.IndexOf('$') + 1)..];
                    if (charaName.Contains("・"))
                    {
                        if (GetCharaParams(charaName) != null)
                        {
                            param = GetCharaParams(charaName);
                            if (textparam.m_voiceLabel.StartsWith("voice"))
                            {
                                if (param.m_CueSheet != "")
                                {
                                    DownloadPackVoice(param.m_CueSheet, textparam.m_voiceLabel[6..]);
                                }
                                else if (param.m_NamedType != -1)
                                {
                                    DownloadPackVoice(advCharaVoiceLabel.m_Params.First(param0 => param0.m_NamedType == param.m_NamedType).m_VoiceLabel, textparam.m_voiceLabel[6..]);
                                }
                            }
                        }
                        else
                        {
                            string[] charaNames = charaName.Split("・");
                            param = GetCharaParams(CharasExistPreLoad.FirstOrDefault(item => item.Value == charaNames[0]).Key);
                            if (param != null)
                            {
                                if (textparam.m_voiceLabel.StartsWith("voice"))
                                {
                                    if (param.m_CueSheet != "")
                                    {
                                        DownloadPackVoice(param.m_CueSheet, textparam.m_voiceLabel[6..]);
                                    }
                                    else if (param.m_NamedType != -1)
                                    {
                                        DownloadPackVoice(advCharaVoiceLabel.m_Params.First(param0 => param0.m_NamedType == param.m_NamedType).m_VoiceLabel, textparam.m_voiceLabel[6..]);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        param = GetCharaParams(charaName);
                        if (textparam.m_voiceLabel.StartsWith("voice"))
                        {
                            if (param.m_CueSheet != "")
                            {
                                DownloadPackVoice(param.m_CueSheet, textparam.m_voiceLabel[6..]);
                            }
                            else if (param.m_NamedType != -1)
                            {
                                DownloadPackVoice(advCharaVoiceLabel.m_Params.First(param0 => param0.m_NamedType == param.m_NamedType).m_VoiceLabel, textparam.m_voiceLabel[6..]);
                            }
                        }
                    }
                    if (func.argNum == 3)
                    {
                        emoParam = advEmotionList.m_Params.First(param => param.m_EmotionID == func.m_value3);
                        DownloadPackEffect(emoParam.m_EffectID);
                    }
                    break;
                case "CharaTalkFullVoice":
                    textparam = advScriptText.m_Params[int.Parse(func.m_value1)];
                    if (textparam.m_voiceLabel.StartsWith("voice"))
                    {
                        if (!LoadingIEnumerators.ContainsKey(advList.m_Params.First(param0 => param0.m_AdvID == ADVID).m_CueSheet + "_" + textparam.m_voiceLabel))
                        {
                            LoadingIEnumerators.Add(advList.m_Params.First(param0 => param0.m_AdvID == ADVID).m_CueSheet + "_" + textparam.m_voiceLabel, DownloadAudio(advList.m_Params.First(param0 => param0.m_AdvID == ADVID).m_CueSheet + "_" + textparam.m_voiceLabel, $"{host}/cuesheet/{advList.m_Params.First(param0 => param0.m_AdvID == ADVID).m_CueSheet}_{textparam.m_voiceLabel}.{audioMode}", audioMode));
                        }
                    }
                    if (func.argNum == 3)
                    {
                        emoParam = advEmotionList.m_Params.First(param => param.m_EmotionID == func.m_value3);
                        DownloadPackEffect(emoParam.m_EffectID);
                    }
                    break;
                case "Effect":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectChara":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectScreen":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectLoop":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectCharaLoop":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectScreenLoop":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectLoopTarget":
                    DownloadPackEffect(func.m_value1);
                    DownloadPackEffect(func.m_value2);
                    break;
                case "EffectCharaLoopTarget":
                    DownloadPackEffect(func.m_value1);
                    DownloadPackEffect(func.m_value2);
                    break;
                case "EffectScreenLoopTarget":
                    DownloadPackEffect(func.m_value1);
                    DownloadPackEffect(func.m_value2);
                    break;
                case "EffectLoopTargetEnd":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "PresetEffectLoop":
                    DownloadPackEffect(func.m_value1);
                    DownloadPackEffect(func.m_value2);
                    DownloadPackEffect(func.m_value3);
                    break;
                case "Effect_CharaBehind":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectChara_CharaBehind":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectScreen_CharaBehind":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectLoop_CharaBehind":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectCharaLoop_CharaBehind":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectScreenLoop_CharaBehind":
                    DownloadPackEffect(func.m_value1);
                    break;
                case "EffectLoopTarget_CharaBehind":
                    DownloadPackEffect(func.m_value1);
                    DownloadPackEffect(func.m_value2);
                    break;
                case "EffectCharaLoopTarget_CharaBehind":
                    DownloadPackEffect(func.m_value1);
                    DownloadPackEffect(func.m_value2);
                    break;
                case "EffectScreenLoopTarget_CharaBehind":
                    DownloadPackEffect(func.m_value1);
                    DownloadPackEffect(func.m_value2);
                    break;
                case "PlayBGM":
                    if (!LoadingIEnumerators.ContainsKey(func.m_value1))
                    {
                        LoadingIEnumerators.Add(func.m_value1, DownloadAudio(func.m_value1, $"{host}/bgm/{func.m_value1}.wav", "wav"));
                    }
                    break;
                case "PlaySE":
                    if (!LoadingIEnumerators.ContainsKey(func.m_value1))
                    {
                        LoadingIEnumerators.Add(func.m_value1, DownloadAudio(func.m_value1, $"{host}/se/{func.m_value1}.wav", "wav"));
                    }
                    break;
                case "PlayVOICE":
                    param = GetCharaParams(func.m_value1);
                    if (param.m_CueSheet != "")
                    {
                        DownloadPackVoice(param.m_CueSheet, func.m_value2);
                    }
                    else if (param.m_NamedType != -1)
                    {
                        DownloadPackVoice(advCharaVoiceLabel.m_Params.First(param0 => param0.m_NamedType == param.m_NamedType).m_VoiceLabel, func.m_value2);
                    }
                    break;
                case "PlayVOICECueName":
                    param = GetCharaParams(func.m_value1);
                    if (param.m_CueSheet != "")
                    {
                        DownloadPackVoice(param.m_CueSheet, func.m_value2[6..]);
                    }
                    else if (param.m_NamedType != -1)
                    {
                        DownloadPackVoice(advCharaVoiceLabel.m_Params.First(param0 => param0.m_NamedType == param.m_NamedType).m_VoiceLabel, func.m_value2[6..]);
                    }
                    break;
                case "PlayFULLVOICE":
                    if (!LoadingIEnumerators.ContainsKey(advList.m_Params.First(param => param.m_AdvID == ADVID).m_CueSheet + "_" + func.m_value1))
                    {
                        LoadingIEnumerators.Add(advList.m_Params.First(param => param.m_AdvID == ADVID).m_CueSheet + "_" + func.m_value1, DownloadAudio(advList.m_Params.First(param => param.m_AdvID == ADVID).m_CueSheet + "_" + func.m_value1, $"{host}/cuesheet/{advList.m_Params.First(param => param.m_AdvID == ADVID).m_CueSheet}_{func.m_value1}.{audioMode}", audioMode));
                    }
                    break;
                default:
                    break;
            }
        }
        foreach (advscripttext_Params advscripttext_Params in advScriptTexts[ADVID].m_Params)
        {
            Dictionary<int, List<List<string>>> parsed = ParseScriptText(advscripttext_Params.m_text);
            advcharacterlist_Params param;
            for (int i = 0; i < advscripttext_Params.m_text.Length; i++)
            {
                if (advscripttext_Params.m_text[i] == '<')
                {
                    foreach (List<string> command in parsed[i])
                    {
                        switch (command[0])
                        {
                            case "voice":
                                param = GetCharaParams(command[1]);
                                if (param != null)
                                {
                                    if (param.m_CueSheet != "")
                                    {
                                        DownloadPackVoice(param.m_CueSheet, command[2][6..]);
                                    }
                                    else if (param.m_NamedType != -1)
                                    {
                                        DownloadPackVoice(advCharaVoiceLabel.m_Params.First(param0 => param0.m_NamedType == param.m_NamedType).m_VoiceLabel, command[2][6..]);
                                    }
                                }
                                break;
                            case "se":
                                if (!LoadingIEnumerators.ContainsKey(command[1]))
                                {
                                    LoadingIEnumerators.Add(command[1], DownloadAudio(command[1], $"{host}/se/{command[1]}.wav", "wav"));
                                }
                                break;
                            case "emo":
                                DownloadPackEffect(advEmotionList.m_Params.First(param => param.m_EmotionID == command[2]).m_EffectID);
                                break;
                        }
                    }
                }
            }
        }
    }
    private IEnumerator autoSpin()
    {
        float timeElapsed = 0f;
        while (true)
        {
            timeElapsed += Time.deltaTime;
            ADVAutoIcon.GetComponent<RectTransform>().localRotation = Quaternion.Euler(new Vector3(0f, 0f, -timeElapsed * 120f));
            ADVAutoLabelBG.SetActive(auto);
            yield return null;
        }
    }
    private IEnumerator PenCycle()
    {
        float timeElapsed = 0f;
        while (true)
        {
            timeElapsed += Time.deltaTime;
            int a = (int)(timeElapsed * 0.75f) % 2;
            float b = timeElapsed * 0.75f % 1;
            if (a == 0)
            {
                ADVPen.GetComponent<RectTransform>().localPosition = new Vector3(464f, Mathf.Lerp(10f, 2f, Ease(b, 3)), 0f);
                ADVPenShadow.GetComponent<RectTransform>().localScale = new Vector3(Mathf.Lerp(0.7f, 1f, Ease(b, 3)), 1f, 1f);
            }
            else
            {
                ADVPen.GetComponent<RectTransform>().localPosition = new Vector3(464f, Mathf.Lerp(2f, 10f, Ease(b, 3)), 0f);
                ADVPenShadow.GetComponent<RectTransform>().localScale = new Vector3(Mathf.Lerp(1f, 0.7f, Ease(b, 3)), 1f, 1f);
            }
            yield return null;
        }
    }
    private IEnumerator PenClick()
    {
        float timeElapsed = 0f;
        while (timeElapsed < 0.5f)
        {
            timeElapsed += Time.deltaTime;
            int a = (int)(timeElapsed * 10);
            float b = timeElapsed * 10 % 1;
            switch (a)
            {
                case 0:
                    ADVPen.GetComponent<RectTransform>().localPosition = new Vector3(464f, 10f, 0f);
                    ADVPenShadow.GetComponent<RectTransform>().localScale = new Vector3(0.7f, 1f, 1f);
                    break;
                case 1:
                    ADVPen.GetComponent<RectTransform>().localPosition = new Vector3(464f, Mathf.Lerp(10f, 2f, Ease(b, 6)), 0f);
                    ADVPenShadow.GetComponent<RectTransform>().localScale = new Vector3(Mathf.Lerp(0.7f, 1f, Ease(b, 6)), 1f, 1f);
                    break;
                case 2:
                    ADVPen.GetComponent<RectTransform>().localPosition = new Vector3(464f, 2f, 0f);
                    ADVPenShadow.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
                    break;
                case 3:
                    ADVPen.GetComponent<RectTransform>().localPosition = new Vector3(464f, Mathf.Lerp(2f, 10f, Ease(b, 6)), 0f);
                    ADVPenShadow.GetComponent<RectTransform>().localScale = new Vector3(Mathf.Lerp(1f, 0.7f, Ease(b, 6)), 1f, 1f);
                    break;
                case 4:
                    ADVPen.GetComponent<RectTransform>().localPosition = new Vector3(464f, 10f, 0f);
                    ADVPenShadow.GetComponent<RectTransform>().localScale = new Vector3(0.7f, 1f, 1f);
                    break;
            }
            yield return null;
        }
        timeElapsed = 0f;
        while (true)
        {
            timeElapsed += Time.deltaTime;
            int a = (int)(timeElapsed * 0.75f) % 2;
            float b = timeElapsed * 0.75f % 1;
            if (a == 0)
            {
                ADVPen.GetComponent<RectTransform>().localPosition = new Vector3(464f, Mathf.Lerp(10f, 2f, Ease(b, 3)), 0f);
                ADVPenShadow.GetComponent<RectTransform>().localScale = new Vector3(Mathf.Lerp(0.7f, 1f, Ease(b, 3)), 1f, 1f);
            }
            else
            {
                ADVPen.GetComponent<RectTransform>().localPosition = new Vector3(464f, Mathf.Lerp(2f, 10f, Ease(b, 3)), 0f);
                ADVPenShadow.GetComponent<RectTransform>().localScale = new Vector3(Mathf.Lerp(1f, 0.7f, Ease(b, 3)), 1f, 1f);
            }
            yield return null;
        }
    }
    private IEnumerator LoadCustomJson()
    {
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/script/ADVList.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string listjson = request.downloadHandler.text;
                advList = JsonConvert.DeserializeObject<advlist>(listjson);
                break;
            }
        }
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/script/ADVCharacterList.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string charajson = request.downloadHandler.text;
                advCharacterList = JsonConvert.DeserializeObject<advcharacterlist>(charajson);
                break;
            }
        }
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/script/ADVMotionList.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string motjson = request.downloadHandler.text;
                advMotionList = JsonConvert.DeserializeObject<advmotionlist>(motjson);
                break;
            }
        }
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/script/ADVEmotionList.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string emojson = request.downloadHandler.text;
                advEmotionList = JsonConvert.DeserializeObject<advemotionlist>(emojson);
                break;
            }
        }
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/charavoice.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string charaVoicejson = request.downloadHandler.text;
                advCharaVoiceLabel = JsonConvert.DeserializeObject<advcharavoicelabel>(charaVoicejson);
                break;
            }
        }
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/script/ADVTextTagArg.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string textTagArgjson = request.downloadHandler.text;
                advTextTagArg = JsonConvert.DeserializeObject<advtexttagarg>(textTagArgjson);
                break;
            }
        }
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/effectlist.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string effectjson = request.downloadHandler.text;
                advEffectList = JsonConvert.DeserializeObject<adveffectlist>(effectjson);
                break;
            }
        }
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/customadv.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string customjson = request.downloadHandler.text;
                advCustomList = JsonConvert.DeserializeObject<advlist>(customjson);
                foreach (advlist_Params advlist_Params in advCustomList.m_Params)
                {
                    advList.m_Params.Add(advlist_Params);
                }
                break;
            }
        }
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/standpics.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string standpicsjson = request.downloadHandler.text;
                StandPics = JsonConvert.DeserializeObject<standpics>(standpicsjson);
                break;
            }
        }
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/effects.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string effectsjson = request.downloadHandler.text;
                Effects = JsonConvert.DeserializeObject<standpics>(effectsjson);
                break;
            }
        }
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get($"{host}/voices.json");
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
                string voicesjson = request.downloadHandler.text;
                Voices = JsonConvert.DeserializeObject<voices>(voicesjson);
                break;
            }
        }
        BuildLookupDictionaries();
        JsonLoading = false;
    }
    private Mesh CreateMesh(float width, float height, Vector2 pivot)
    {
        Vector4 meshParams = new Vector4(width, height, pivot.x, pivot.y);
        if (meshCache.ContainsKey(meshParams))
        {
            return meshCache[meshParams];
        }
        Mesh mesh = new Mesh { name = "Quad1920x1080" };
        float x0 = -width * pivot.x;
        float x1 = width * (1 - pivot.x);
        float y0 = -height * pivot.y;
        float y1 = height * (1 - pivot.y);
        mesh.vertices = new Vector3[]
        {
            new Vector3(x0, y0, 0),
            new Vector3(x1, y0, 0),
            new Vector3(x0, y1, 0),
            new Vector3(x1, y1, 0)
        };
        mesh.triangles = new int[]
        {
            0, 2, 1,
            2, 3, 1
        };
        mesh.normals = new Vector3[]
        {
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward
        };
        mesh.uv = new Vector2[]
        {
            new Vector2(0f, 0f),
            new Vector2(1f, 0f),
            new Vector2(0f, 1f),
            new Vector2(1f, 1f)
        };
        meshCache[meshParams] = mesh;
        return mesh;
    }
    void Start()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        Application.targetFrameRate = -1;
        host = "https://assets.krf-adv.com/adv";
        audioMode = "ogg";
        globalFont = "ja";
        useCustomJson = false;
        Attempt = 3;
        AttemptDelay = 1f;
        string jsonStr = GetPlaylistFromLocalStorage();
        ADVIDs = JsonConvert.DeserializeObject<List<int>>(jsonStr);
        BGMVolume = Mathf.Clamp(ADVIDs[0] / 100f, 0f, 1f);
        SEVolume = Mathf.Clamp(ADVIDs[1] / 100f, 0f, 1f);
        VoiceVolume = Mathf.Clamp(ADVIDs[2] / 100f, 0f, 1f);
        ADVIDs.RemoveRange(0, 3);
        ClearPlaylistInLocalStorage();
#elif UNITY_EDITOR
        Application.targetFrameRate = 60;
        host = "https://assets.krf-adv.com/adv";
        DebugMode = true;
#else
        Application.targetFrameRate = 60;
        string ParametersPath = Path.Combine(Application.streamingAssetsPath, "Params.json");
        string paramjson = File.ReadAllText(ParametersPath);
        Parameters parameters = JsonConvert.DeserializeObject<Parameters>(paramjson);
        if (!DebugMode)
        {
            ADVIDs = parameters.ADVIDs;
            host = parameters.Host;
            globalFont = parameters.Font;
            audioMode = parameters.AudioMode == "wav" ? "wav" : "ogg";
            BGMVolume = Mathf.Clamp(parameters.Volume.BGM / 100f, 0f, 1f);
            SEVolume = Mathf.Clamp(parameters.Volume.SE / 100f, 0f, 1f);
            VoiceVolume = Mathf.Clamp(parameters.Volume.Voice / 100f, 0f, 1f);
        }
#endif
        switch (globalFont)
        {
            case "ja":
                font = Resources.Load<Font>("DynamicFont");
                break;
            case "zh":
                font = Resources.Load<Font>("cnfont");
                break;
            default:
                font = Resources.Load<Font>("DynamicFont");
                break;
        }
#if UNITY_WEBGL
#else
        Screen.fullScreen = false;
        Screen.SetResolution(parameters.Width, 9 * parameters.Width / 16, false);
#endif
        Camera mainCamera = Camera.main;
        cachedMainCameraTransform = mainCamera.transform;
        renderTexture = new RenderTexture(1920, 1080, 24);
        Render = new GameObject("Render");
        Render.transform.position = new Vector3(-20000f, 0f, 0f);
        Render.transform.localScale = new Vector3(25f / 36f, 25f / 36f, 1f);
        renderSpriteRenderer = Render.AddComponent<SpriteRenderer>();
        SpriteRenderer spriteRenderer = renderSpriteRenderer;
        Audios = new GameObject("Audios");
        Audios.transform.position = new Vector3(20000f, 0f, 0f);
        Material PPmaterial = new Material(Shader.Find("CustomShader_PP"));
        PPmaterial.SetTexture("_RenderTex", renderTexture);
        PPmaterial.SetInt(_BlendSrc, 1);
        PPmaterial.SetInt(_BlendDst, 10);
        Texture2D black = Resources.Load<Texture2D>("black");
        spriteRenderer.sprite = Sprite.Create(black, new Rect(0, 0, black.width, black.height), new Vector2(0.5f, 0.5f), 1);
        spriteRenderer.material = PPmaterial;
        spriteRenderer.sortingOrder = -3;
        image = new GameObject("Image");
        image.transform.SetParent(Render.transform);
        imageSpriteRenderer = image.AddComponent<SpriteRenderer>();
        SpriteRenderer ImageRenderer = imageSpriteRenderer;
        Texture2D white = Resources.Load<Texture2D>("white");
        ImageRenderer.sprite = Sprite.Create(white, new Rect(0, 0, white.width, white.height), new Vector2(0.5f, 0.5f), 1);
        ImageRenderer.sortingOrder = -3;
        ImageRenderer.color = new Color(0f, 0f, 0f, 1f);
        image.layer = LayerMask.NameToLayer("Main");
        renderTexture.Create();
        mainCamera.transform.position = new Vector3(-20000f, 0f, -10f);
        mainCamera.orthographic = true;
        mainCamera.orthographicSize = 375f;
        mainCamera.nearClipPlane = 0.3f;
        mainCamera.farClipPlane = 200000f;
        mainCamera.clearFlags = CameraClearFlags.SolidColor;
        mainCamera.depth = 1;
        canvasObj = new GameObject("Canvas");
        canvas = canvasObj.AddComponent<Canvas>();
        canvas.referencePixelsPerUnit = 1;
        canvas.renderMode = RenderMode.WorldSpace;
        canvas.worldCamera = mainCamera;
        canvas.transform.position = new Vector3(0f, 0f, 0f);
        RectTransform canvasTransform = canvasObj.GetComponent<RectTransform>();
        canvasTransform.position = new Vector3(0f, 0f, 0f);
        canvasTransform.sizeDelta = new Vector2(4000f / 3f, 750f);
        canvasTransform.anchorMax = new Vector2(0f, 0f);
        canvasTransform.anchorMin = new Vector2(0f, 0f);
        canvasObj.AddComponent<CanvasScaler>();
        effectCanvasObj = new GameObject("EffectCanvas");
        effectCanvas = effectCanvasObj.AddComponent<Canvas>();
        effectCanvas.referencePixelsPerUnit = 1;
        effectCanvas.renderMode = RenderMode.WorldSpace;
        effectCanvas.worldCamera = mainCamera;
        effectCanvas.transform.position = new Vector3(0f, 0f, 0f);
        RectTransform effectTransform = effectCanvasObj.GetComponent<RectTransform>();
        effectTransform.position = new Vector3(0f, 0f, 0f);
        effectTransform.sizeDelta = new Vector2(4000f / 3f, 750f);
        effectTransform.anchorMax = new Vector2(0f, 0f);
        effectTransform.anchorMin = new Vector2(0f, 0f);
        textCanvasObj = new GameObject("TextCanvas");
        textCanvas = textCanvasObj.AddComponent<Canvas>();
        textCanvas.renderMode = RenderMode.WorldSpace;
        textCanvas.worldCamera = mainCamera;
        RectTransform rectTransform = textCanvasObj.GetComponent<RectTransform>();
        rectTransform.position = new Vector3(-20000f, -381f, 0f);
        GameObject textObj = new GameObject("Text");
        textObj.transform.SetParent(textCanvas.transform);
        RectTransform textTransform = textObj.AddComponent<RectTransform>();
        textTransform.localPosition = new Vector3(30f, 0f, 0f);
        textTransform.sizeDelta = new Vector2(900f, 96f);
        textTransform.localScale = new Vector3(1f, 1f, 1f);
        Text text = textObj.AddComponent<Text>();
        text.font = font;
        text.fontSize = 36;
        text.lineSpacing = lineSpacing[globalFont];
        text.color = new Color(0.431372553f, 0.254901975f, 0.20784314f, 1f);
        CanvasGroup textGroup = textObj.AddComponent<CanvasGroup>();
        textGroup.alpha = 0f;
        GameObject nameObj = new GameObject("Name");
        nameObj.transform.SetParent(textCanvas.transform);
        RectTransform nameTransform = nameObj.AddComponent<RectTransform>();
        nameTransform.localPosition = new Vector3(-379f, 105.5f, 0f);
        nameTransform.sizeDelta = new Vector2(900f, 96f);
        nameTransform.localScale = new Vector3(1f, 1f, 1f);
        Text name = nameObj.AddComponent<Text>();
        name.font = font;
        name.fontSize = 36;
        name.lineSpacing = lineSpacing[globalFont];
        name.color = new Color(1f, 1f, 1f, 1f);
        name.alignment = TextAnchor.MiddleCenter;
        CanvasGroup nameGroup = nameObj.AddComponent<CanvasGroup>();
        nameGroup.alpha = 0f;
        GameObject ADVWindow = new GameObject("ADVWindow");
        ADVWindow.transform.SetParent(textCanvasObj.transform);
        RectTransform windowTransform = ADVWindow.AddComponent<RectTransform>();
        windowTransform.localPosition = new Vector3(0f, 6f, 0f);
        SpriteRenderer windowRenderer = ADVWindow.AddComponent<SpriteRenderer>();
        Texture2D windowTexture = Resources.Load<Texture2D>("ADVWindow");
        windowTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite windowSprite = Sprite.Create(windowTexture, new Rect(0, 0, windowTexture.width, windowTexture.height), new Vector2(0.5f, 0.5f), 1f, 0, SpriteMeshType.FullRect, new Vector4(16, 16, 16, 16));
        windowRenderer.sprite = windowSprite;
        windowRenderer.drawMode = SpriteDrawMode.Sliced;
        windowRenderer.size = new Vector2(960f, 180f);
        windowRenderer.sortingOrder = -2;
        windowRenderer.color = new Color(1f, 1f, 1f, 0f);
        GameObject ADVTalkerLabelBG = new GameObject("ADVTalkerLabelBG");
        ADVTalkerLabelBG.transform.SetParent(textCanvasObj.transform);
        RectTransform talkerTransform = ADVTalkerLabelBG.AddComponent<RectTransform>();
        talkerTransform.localPosition = new Vector3(-367f, 104f, 0f);
        talkerRenderer = ADVTalkerLabelBG.AddComponent<SpriteRenderer>();
        Texture2D talkerTexture = Resources.Load<Texture2D>("ADVTalkerLabelBG");
        talkerTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite talkerSprite = Sprite.Create(talkerTexture, new Rect(0, 0, talkerTexture.width, talkerTexture.height), new Vector2(0.5f, 0.5f), 1f, 0, SpriteMeshType.FullRect, new Vector4(104, 14, 34, 10));
        talkerRenderer.sprite = talkerSprite;
        talkerRenderer.drawMode = SpriteDrawMode.Sliced;
        talkerRenderer.size = new Vector2(437f, 69f);
        talkerRenderer.sortingOrder = -1;
        talkerRenderer.color = new Color(1f, 1f, 1f, 0f);
        ADVAutoLabelBG = new GameObject("ADVAutoLabelBG");
        ADVAutoLabelBG.transform.SetParent(textCanvasObj.transform);
        RectTransform autoLabelTransform = ADVAutoLabelBG.AddComponent<RectTransform>();
        autoLabelTransform.localPosition = new Vector3(356f, 140.625f, 0f);
        autoLabelRenderer = ADVAutoLabelBG.AddComponent<SpriteRenderer>();
        Texture2D autoLabelTexture = Resources.Load<Texture2D>("ADVAutoLabelBG");
        autoLabelTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite autoLabelSprite = Sprite.Create(autoLabelTexture, new Rect(0, 0, autoLabelTexture.width, autoLabelTexture.height), new Vector2(0.5f, 0.5f), 1f, 0, SpriteMeshType.FullRect, new Vector4(23, 23, 23, 23));
        autoLabelRenderer.sprite = autoLabelSprite;
        autoLabelRenderer.drawMode = SpriteDrawMode.Sliced;
        autoLabelRenderer.size = new Vector2(256f, 49f);
        autoLabelRenderer.sortingOrder = -2;
        autoLabelRenderer.color = new Color(1f, 1f, 1f, 0f);
        ADVAutoIcon = new GameObject("ADVAutoIcon");
        ADVAutoIcon.transform.SetParent(ADVAutoLabelBG.transform);
        RectTransform autoIconTransform = ADVAutoIcon.AddComponent<RectTransform>();
        autoIconTransform.localPosition = new Vector3(-79f, 0f, 0f);
        autoIconTransform.localScale = new Vector3(1.8f, 1.8f, 1f);
        autoIconRenderer = ADVAutoIcon.AddComponent<SpriteRenderer>();
        Texture2D autoIconTexture = Resources.Load<Texture2D>("ADVAutoIcon");
        autoIconTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite autoIconSprite = Sprite.Create(autoIconTexture, new Rect(0, 0, autoIconTexture.width, autoIconTexture.height), new Vector2(0.5f, 0.5f), 1);
        autoIconRenderer.sprite = autoIconSprite;
        autoIconRenderer.sortingOrder = -1;
        autoIconRenderer.color = new Color(250f / 255f, 250f / 255f, 235f / 255f, 0f);
        GameObject AUTO = new GameObject("AUTO");
        AUTO.transform.SetParent(ADVAutoLabelBG.transform);
        RectTransform AUTOTransform = AUTO.AddComponent<RectTransform>();
        AUTOTransform.localPosition = new Vector3(27f, 0f, 0f);
        AUTORenderer = AUTO.AddComponent<SpriteRenderer>();
        Texture2D AUTOTexture = Resources.Load<Texture2D>("AUTO");
        AUTOTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite AUTOSprite = Sprite.Create(AUTOTexture, new Rect(0, 0, AUTOTexture.width, AUTOTexture.height), new Vector2(0.5f, 0.5f), 1);
        AUTORenderer.sprite = AUTOSprite;
        AUTORenderer.sortingOrder = -1;
        AUTORenderer.color = new Color(250f / 255f, 250f / 255f, 235f / 255f, 0f);
        ADVPen = new GameObject("ADVPen");
        ADVPen.transform.SetParent(textCanvas.transform);
        RectTransform PenTransform = ADVPen.AddComponent<RectTransform>();
        PenTransform.localPosition = new Vector3(464f, 10f, 0f);
        SpriteRenderer PenRenderer = ADVPen.AddComponent<SpriteRenderer>();
        Texture2D PenTexture = Resources.Load<Texture2D>("ADVPen");
        PenTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite PenSprite = Sprite.Create(PenTexture, new Rect(0, 0, PenTexture.width, PenTexture.height), new Vector2(0.5f, 0.5f), 1);
        PenRenderer.sprite = PenSprite;
        PenRenderer.sortingOrder = -1;
        PenRenderer.color = new Color(1f, 1f, 1f, 0f);
        ADVPenShadow = new GameObject("ADVPenShadow");
        ADVPenShadow.transform.SetParent(textCanvas.transform);
        RectTransform PenShadowTransform = ADVPenShadow.AddComponent<RectTransform>();
        PenShadowTransform.localPosition = new Vector3(440f, -43f, 0f);
        PenShadowTransform.localScale = new Vector3(0.7f, 1f, 1f);
        SpriteRenderer PenShadowRenderer = ADVPenShadow.AddComponent<SpriteRenderer>();
        Texture2D PenShadowTexture = Resources.Load<Texture2D>("ADVPenShadow");
        PenShadowTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite PenShadowSprite = Sprite.Create(PenShadowTexture, new Rect(0, 0, PenShadowTexture.width, PenShadowTexture.height), new Vector2(0.5f, 0.5f), 1);
        PenShadowRenderer.sprite = PenShadowSprite;
        PenShadowRenderer.sortingOrder = -1;
        PenShadowRenderer.color = new Color(1f, 1f, 1f, 0f);
        canvas.sortingOrder = -3;
        camerasObj = new GameObject("Cameras");
        for (int i = 0; i < 10; i++)
        {
            GameObject cameraObj = new GameObject("Camera_" + i.ToString());
            cameraObj.transform.SetParent(camerasObj.transform);
            Camera newCamera = cameraObj.AddComponent<Camera>();
            cameras.Add(newCamera);
            newCamera.transform.position = new Vector3(0f, 10000f, -10000f);
            newCamera.orthographic = true;
            newCamera.orthographicSize = 375;
            newCamera.nearClipPlane = 0.3f;
            newCamera.farClipPlane = 200000f;
            newCamera.backgroundColor = new Color(0f, 0f, 0f, 0f);
            newCamera.cullingMask = 1 << LayerMask.NameToLayer("Chara" + i.ToString());
        }
        SetCamera("Camera_BG", 0, "BG", CameraClearFlags.SolidColor);
        SetCamera("Camera_Effect_CharaBehind", 1, "Effect_CharaBehind", CameraClearFlags.Depth);
        SetCamera("Camera_Chara", 2, "Chara", CameraClearFlags.Depth);
        SetCamera("Camera_Effect", 3, "Effect", CameraClearFlags.Depth);
        SetCamera("Camera_Sprite", 4, "Sprite", CameraClearFlags.Depth);
        SetCamera("Camera_Caption", 5, "Caption", CameraClearFlags.Depth);
        SetCamera("Camera_Main", 6, "Main", CameraClearFlags.Depth);
        renderTextureObj = new GameObject("RenderTextures");
        renderTextureObj.transform.position = new Vector3(0f, 0f, 0f);
        bgTexture = new RenderTexture(4000, 2250, 24);
        GameObject bgPrim = new GameObject("Camera_BG_Prim");
        bgPrim.transform.SetParent(camerasObj.transform);
        Camera bgPrimCamera = bgPrim.AddComponent<Camera>();
        bgPrimCamera.transform.position = new Vector3(0f, 0f, -10000f);
        bgPrimCamera.orthographic = true;
        bgPrimCamera.orthographicSize = 375;
        bgPrimCamera.nearClipPlane = 0.3f;
        bgPrimCamera.farClipPlane = 200000f;
        bgPrimCamera.backgroundColor = new Color(0f, 0f, 0f, 0f);
        bgPrimCamera.cullingMask = 1 << LayerMask.NameToLayer("BG_Prim");
        bgPrimCamera.targetTexture = bgTexture;
        bgPrimObj = new GameObject("BG_Prim");
        bgPrimObj.transform.SetParent(Render.transform);
        bgPrimObj.transform.position = new Vector3(0f, 0f, 0f);
        MeshFilter bgPrimMeshFilter = bgPrimObj.AddComponent<MeshFilter>();
        bgPrimMeshFilter.mesh = CreateMesh(4000f/3f, 2250f/3f, new Vector2(0.5f, 0.5f));
        MeshRenderer bgPrimRenderer = bgPrimObj.AddComponent<MeshRenderer>();
        Material bgPrimMaterial = new Material(Shader.Find("CustomShader_COMMON"));
        bgPrimMaterial.SetTexture(_MainTex, bgTexture);
        bgPrimMaterial.SetInt(_BlendSrc, 1);
        bgPrimMaterial.SetInt(_BlendDst, 10);
        bgPrimMaterial.SetTexture("_Texture_Noise", Resources.Load<Texture2D>("Noise_perlin"));
        bgPrimMaterial.SetTexture("_Texture_Level", Resources.Load<Texture2D>("Noise_perlin"));
        bgPrimRenderer.material = bgPrimMaterial;
        bgPrimRenderer.sortingOrder = -3;
        bgPrimObj.layer = LayerMask.NameToLayer("BG");
        particleObj = new GameObject("Particle");
        particleObj.transform.position = new Vector3(0f, 0f, 0f);
        if (useCustomJson)
        {
            StartCoroutine(LoadCustomJson());
        }
        else
        {
            string listjson = Resources.Load<TextAsset>("ADVList").text;
            advList = JsonConvert.DeserializeObject<advlist>(listjson);
            string charajson = Resources.Load<TextAsset>("ADVCharacterList").text;
            advCharacterList = JsonConvert.DeserializeObject<advcharacterlist>(charajson);
            string motjson = Resources.Load<TextAsset>("ADVMotionList").text;
            advMotionList = JsonConvert.DeserializeObject<advmotionlist>(motjson);
            string emojson = Resources.Load<TextAsset>("ADVEmotionList").text;
            advEmotionList = JsonConvert.DeserializeObject<advemotionlist>(emojson);
            string charaVoicejson = Resources.Load<TextAsset>("charavoice").text;
            advCharaVoiceLabel = JsonConvert.DeserializeObject<advcharavoicelabel>(charaVoicejson);
            string textTagArgjson = Resources.Load<TextAsset>("ADVTextTagArg").text;
            advTextTagArg = JsonConvert.DeserializeObject<advtexttagarg>(textTagArgjson);
            string effectjson = Resources.Load<TextAsset>("effectlist").text;
            advEffectList = JsonConvert.DeserializeObject<adveffectlist>(effectjson);
            string standpicsjson = Resources.Load<TextAsset>("standpics").text;
            StandPics = JsonConvert.DeserializeObject<standpics>(standpicsjson);
            string effectsjson = Resources.Load<TextAsset>("effects").text;
            Effects = JsonConvert.DeserializeObject<standpics>(effectsjson);
            string voicesjson = Resources.Load<TextAsset>("voices").text;
            Voices = JsonConvert.DeserializeObject<voices>(voicesjson);
            BuildLookupDictionaries();
            JsonLoading = false;
        }
        GameObject SceneChange = new GameObject("SceneChange");
        SceneChange.transform.localPosition = new Vector3(-20000f, 0f, 0f);
        SceneChange.transform.localScale = new Vector3(0.75f, 0.75f, 1f);
        Canvas scCanvas = SceneChange.AddComponent<Canvas>();
        scCanvas.renderMode = RenderMode.WorldSpace;
        scCanvas.worldCamera = Camera.main;
        Texture2D scTexture = Resources.Load<Texture2D>("SceneChange");
        scTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite scSprite = Sprite.Create(scTexture, new Rect(0, 0, scTexture.width, scTexture.height), new Vector2(0.5f, 0.5f), 1);
        for (int i = -3; i <= 3; i++)
        {
            for (float j = 1.5f; j >= -1.5f; j--)
            {
                GameObject sc = new GameObject(i.ToString() + "," + j.ToString());
                SpriteRenderer scRenderer = sc.AddComponent<SpriteRenderer>();
                scRenderer.sprite = scSprite;
                scRenderer.sortingOrder = -2;
                sc.transform.SetParent(SceneChange.transform);
                sc.transform.localPosition = new Vector3(i * 256f, j * 256f, 0f);
                sc.transform.localScale = new Vector3(1f, 1f, 1f);
                sc.transform.localRotation = new Quaternion(1f, 1f, 0f, 0f);
            }
        }
    }
    private void SetCamera(string cameraName, int depth, string cullingLayer, CameraClearFlags clearFlags){
        GameObject newCamera = new GameObject(cameraName);
        newCamera.transform.SetParent(camerasObj.transform);
        Camera newCameraComponent = newCamera.AddComponent<Camera>();
        UniversalAdditionalCameraData cameraData = newCameraComponent.GetUniversalAdditionalCameraData();
        newCameraComponent.transform.position = new Vector3(0f, 0f, -10000f);
        newCameraComponent.orthographic = true;
        newCameraComponent.orthographicSize = 375;
        newCameraComponent.nearClipPlane = 0.3f;
        newCameraComponent.farClipPlane = 200000f;
        newCameraComponent.backgroundColor = new Color(0f, 0f, 0f, (depth == 0) ? 1f : 0f);
        newCameraComponent.cullingMask = 1 << LayerMask.NameToLayer(cullingLayer);
        newCameraComponent.clearFlags = clearFlags;
        newCameraComponent.depth = depth;
        newCameraComponent.targetTexture = renderTexture;
        if (depth == 0) {
            cameraData.renderType = CameraRenderType.Base;
        } else {
            cameraData.renderType = CameraRenderType.Overlay;
            UniversalAdditionalCameraData bgCameraData = GameObject.Find("Camera_BG").GetComponent<Camera>().GetUniversalAdditionalCameraData();
            bgCameraData.cameraStack.Add(newCameraComponent);
        }
    }
    private void SetUp()
    {
        Resources.UnloadUnusedAssets();
        GC.Collect();
        gameObjectCache.Clear();
        particleObjectParamsCache.Clear();
        particleUnitParamsCache.Clear();
        advScriptProgress = 0;
        CharaShots = new int[5] { 0, 1, 2, 3, 4 };
        CharaTargets = new string[5] { "-1", "-1", "-1", "-1", "-1" };
        CharasExist.Clear();
        CharasLayer.Clear();
        charaPropertiesDict.Clear();
        charaCoroutinesDict.Clear();
        CharaMoving.Clear();
        CharaMotioning.Clear();
        CharaFading.Clear();
        CharaRotating.Clear();
        Emotioning.Clear();
        Effecting.Clear();
        bgCoroutinesDict.Clear();
        spriteCoroutinesDict.Clear();
        SEPlaying.Clear();
        talkingChara.Clear();
        highlightChara.Clear();
        forceHighlight.Clear();
        forceShading.Clear();
        charaPriorityFirst.Clear();
        charaPriorityMid.Clear();
        charaPriorityLast.Clear();
        isUpdateCharaDestroy.Clear();
        EffectPreset = new string[3];
        renderSpriteRenderer.material.SetFloat("_EnableColorBlend", 0);
        preRead = true;
        if (BGDistortionCoroutine != null) { StopCoroutine(BGDistortionCoroutine); }
        BGDistortionCoroutine = StartCoroutine(BGDistortion());
        warpPreparing.Clear();
        warpPrepared.Clear();
        warpping.Clear();
        foreach (Transform transform in renderTextureObj.GetComponentsInChildren<Transform>()[1..])
        {
            Destroy(transform.gameObject);
        }
    }
    private IEnumerator StartingLoading()
    {
        webText = new Dictionary<string, string>();
        foreach (Texture2D texture2D in webTexture.Values)
        {
            Destroy(texture2D);
        }
        webTexture = new Dictionary<string, Texture2D>();
        foreach (AudioClip audioClip in webAudio.Values)
        {
            Destroy(audioClip);
        }
        webAudio = new Dictionary<string, AudioClip>();
        foreach (AssetBundle assetBundle in webAssetBundle.Values)
        {
            assetBundle.Unload(true);
        }
        webAssetBundle = new Dictionary<string, AssetBundle>();
        foreach (GameObject gameObject in webGameObject.Values)
        {
            Destroy(gameObject);
        }
        webGameObject = new Dictionary<string, GameObject>();
        LoadingIEnumerators = new Dictionary<string, IEnumerator>();
        LoadedPacks = new List<string>();
        Jsons = new Dictionary<int, string[]>();
        LoadedAssets = new List<string>();
        PreloadEnd = false;
        List<Coroutine> Preloads = new List<Coroutine>();
        if (ADVIDs[0] == -2)
        {
            int start = ADVIDs[1];
            int end = ADVIDs[2];
            ADVIDs = new List<int>();
            for (int i = start; i < end; i++)
            {
                ADVIDs.Add(advList.m_Params[i].m_AdvID);
            }
        }
        if (ADVIDs[0] == -3)
        {
            ADVIDs[1]++;
            if (ADVIDs[1] == advList.m_Params.Count)
            {
                ADVIDs = new List<int> { 0 };
#if !UNITY_WEBGL
                Application.Quit();
#endif
#if UNITY_EDITOR
                EditorApplication.isPlaying = false;
#endif
            }
            else
            {
                ADVIDs[2] = advList.m_Params[ADVIDs[1]].m_AdvID;
                Debug.Log(ADVIDs[2]);
            }
        }
        Coroutine coroutine = StartCoroutine(LoadingStart());
        for (int i = 0; i < ADVIDs.Count; i++)
        {
            int ADVID = ADVIDs[i];
            if (ADVID == -1)
            {
                System.Random random = new System.Random();
                int randomADV = random.Next(advList.m_Params.Count);
                ADVID = advList.m_Params[randomADV].m_AdvID;
                ADVIDs[i] = ADVID;
            }
            advlist_Params advlist_Params = advList.m_Params.FirstOrDefault(param => param.m_AdvID == ADVID);
            if (advlist_Params != null)
            {
                if (advlist_Params.m_ScriptName != "" || advlist_Params.m_ComicGroupName != "")
                {
                    yield return StartCoroutine(Preload(ADVID));
                }
            }
        }
        PreloadEnd = true;
        int maxConcurrentLoads = 20, currentActiveLoads = 0;
        Queue<IEnumerator> pendingQueue = new Queue<IEnumerator>(LoadingIEnumerators.Values);
        while (pendingQueue.Count > 0 || currentActiveLoads > 0)
        {
            while (currentActiveLoads < maxConcurrentLoads && pendingQueue.Count > 0)
            {
                IEnumerator nextAsset = pendingQueue.Dequeue();
                currentActiveLoads++;
                StartCoroutine(LoadSingleAssetRoutine(nextAsset, () => 
                {
                    currentActiveLoads--; 
                }));
            }
            yield return null; 
        }
        yield return coroutine;
        SetUp();
        Playing = true;
        ADVIndex = 0;
        ADVID = ADVIDs[ADVIndex];
        while (!advScripts.ContainsKey(ADVID))
        {
            ADVIndex++;
            if (ADVIndex == ADVIDs.Count)
            {
                advScript = new advscript();
                advScript.m_Params = new List<advscript_Params> { new advscript_Params() };
                advScript.m_Params[0].FuncParam = new List<class_FuncParam>();
                advScriptText = new advscripttext();
                yield break;
            }
            ADVID = ADVIDs[ADVIndex];
        }
        Debug.Log(ADVID);
#if UNITY_WEBGL && !UNITY_EDITOR
    SetWebTitle("krfadvplayer - " + ADVID.ToString());
#elif !UNITY_EDITOR
        SetWindowText(GetActiveWindow(), "krfadvplayer - " + ADVID.ToString());
#endif
        advScript = advScripts[ADVID];
        advScriptText = advScriptTexts[ADVID];
        StartCoroutine(autoSpin());
        PenCoroutine = StartCoroutine(PenCycle());
    }
    private IEnumerator LoadSingleAssetRoutine(IEnumerator loadRoutine, Action onComplete)
    {
        yield return StartCoroutine(loadRoutine);
        onComplete?.Invoke();
    }
    private IEnumerator EndingLoading()
    {
        for (float i = 4.5f; i >= -4.5f; i--)
        {
            for (float j = i >= 1.5 ? -3f : -1.5f - i; j <= (i >= -1.5f ? 1.5f - i : 3f); j++)
            {
                float x = j;
                float y = i + j;
                StartCoroutine(FlipSceneChange(x, y, Mathf.Pow(2, 0.5f), 0f, 0.03f));
            }
            yield return new WaitForSeconds(0.03f);
        }
        if (ADVIDs[0] == -3)
        {
            StartLoading = true;
        }
        else
        {
#if !UNITY_WEBGL
            Application.Quit();
#endif
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#endif
        }
    }
    private IEnumerator LoadingStart()
    {
        GameObject SceneChange = GameObject.Find("SceneChange");
        GameObject DLKuromon = new GameObject("DLKuromon");
        Texture2D KuromonTexture = Resources.Load<Texture2D>("DLKuromon");
        KuromonTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite KuromonSprite = Sprite.Create(KuromonTexture, new Rect(0, 0, KuromonTexture.width, KuromonTexture.height), new Vector2(0.5f, 0.5f), 1);
        SpriteRenderer KuromonRenderer = DLKuromon.AddComponent<SpriteRenderer>();
        KuromonRenderer.sprite = KuromonSprite;
        KuromonRenderer.sortingOrder = -1;
        DLKuromon.transform.SetParent(SceneChange.transform);
        DLKuromon.transform.localPosition = new Vector3(768f, -384f, 0f);
        GameObject Loading = new GameObject("Loading");
        Texture2D LoadingTexture = Resources.Load<Texture2D>("Loading");
        LoadingTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite LoadingSprite = Sprite.Create(LoadingTexture, new Rect(0, 0, LoadingTexture.width, LoadingTexture.height), new Vector2(0.5f, 0.5f), 1);
        SpriteRenderer LoadingRenderer = Loading.AddComponent<SpriteRenderer>();
        LoadingRenderer.sprite = LoadingSprite;
        LoadingRenderer.sortingOrder = -1;
        Loading.transform.SetParent(SceneChange.transform);
        Loading.transform.localPosition = new Vector3(540f, -432f, 0f);
        Texture2D DotTexture = Resources.Load<Texture2D>("LoadingDot");
        DotTexture.wrapMode = TextureWrapMode.Clamp;
        Sprite DotSprite = Sprite.Create(DotTexture, new Rect(0, 0, DotTexture.width, DotTexture.height), new Vector2(0.5f, 0.5f), 1);
        GameObject Dot1 = new GameObject("Dot1");
        SpriteRenderer Dot1Renderer = Dot1.AddComponent<SpriteRenderer>();
        Dot1Renderer.sprite = DotSprite;
        Dot1Renderer.sortingOrder = -1;
        Dot1.transform.SetParent(SceneChange.transform);
        Dot1.transform.localPosition = new Vector3(634f, -438f, 0f);
        GameObject Dot2 = new GameObject("Dot2");
        SpriteRenderer Dot2Renderer = Dot2.AddComponent<SpriteRenderer>();
        Dot2Renderer.sprite = DotSprite;
        Dot2Renderer.sortingOrder = -1;
        Dot2.transform.SetParent(SceneChange.transform);
        Dot2.transform.localPosition = new Vector3(644f, -438f, 0f);
        GameObject Dot3 = new GameObject("Dot3");
        SpriteRenderer Dot3Renderer = Dot3.AddComponent<SpriteRenderer>();
        Dot3Renderer.sprite = DotSprite;
        Dot3Renderer.sortingOrder = -1;
        Dot3.transform.SetParent(SceneChange.transform);
        Dot3.transform.localPosition = new Vector3(654f, -438f, 0f);
        float timeElapsed = 0f;
        GameObject Loaded = new GameObject("Loaded");
        Loaded.transform.SetParent(SceneChange.transform);
        RectTransform loadedTransform = Loaded.AddComponent<RectTransform>();
        loadedTransform.localPosition = new Vector3(-300f, 0f, 0f);
        loadedTransform.sizeDelta = new Vector2(1000f, 1000f);
        loadedTransform.localScale = new Vector3(1f, 1f, 1f);
        Text loadedText = Loaded.AddComponent<Text>();
        loadedText.font = font;
        loadedText.fontSize = 16;
        loadedText.lineSpacing = 0.8f;
        loadedText.color = new Color(0.431372553f, 0.254901975f, 0.20784314f, 1f);
        loadedText.text = "Parsing script...";
        loadedText.alignment = TextAnchor.LowerLeft;
        loadedText.verticalOverflow = VerticalWrapMode.Overflow;
        GameObject ToLoad = new GameObject("ToLoad");
        ToLoad.transform.SetParent(SceneChange.transform);
        RectTransform toloadTransform = ToLoad.AddComponent<RectTransform>();
        toloadTransform.localPosition = new Vector3(500f, 0f, 0f);
        toloadTransform.sizeDelta = new Vector2(1000f, 1000f);
        toloadTransform.localScale = new Vector3(1f, 1f, 1f);
        Text toloadText = ToLoad.AddComponent<Text>();
        toloadText.font = font;
        toloadText.fontSize = 16;
        toloadText.lineSpacing = 0.8f;
        toloadText.color = new Color(0.431372553f, 0.254901975f, 0.20784314f, 1f);
        toloadText.text = "";
        toloadText.alignment = TextAnchor.UpperLeft;
        toloadText.verticalOverflow = VerticalWrapMode.Overflow;
        List<string> shown = new List<string>();
        while (!PreloadEnd)
        {
            loadedText.text = "Parsing script(" + (advScripts.Count + advScriptTexts.Count).ToString() + "/" + (ADVIDs.Count * 2).ToString() + ")...";
            yield return null;
        }
        loadedText.text = "";
        int lineLimit = 40;
        List<string> toloadshown = new List<string>(LoadingIEnumerators.Keys);
        int dotStatus = 0, newDotStatus = 0;
        Queue<string> loadedLinesQueue = new Queue<string>();
        StringBuilder toloadBuilder = new StringBuilder();
        int processedAssetCount = 0; 
        bool uiNeedsUpdate = false;
        while (shown.Count != LoadingIEnumerators.Count)
        {
            uiNeedsUpdate = false;
            while (processedAssetCount < LoadedAssets.Count)
            {
                string asset = LoadedAssets[processedAssetCount];

                if (!shown.Contains(asset))
                {
                    shown.Add(asset);
                    string newLine = $"({shown.Count}/{LoadingIEnumerators.Count}) {asset}";
                    loadedLinesQueue.Enqueue(newLine);
                    if (loadedLinesQueue.Count > lineLimit)
                    {
                        loadedLinesQueue.Dequeue();
                    }
                    if (toloadshown.Contains(asset))
                    {
                        toloadshown.Remove(asset);
                    }
                    uiNeedsUpdate = true;
                }
                processedAssetCount++;
            }
            if (uiNeedsUpdate)
            {
                loadedText.text = string.Join("\n", loadedLinesQueue);
                toloadBuilder.Clear();
                int toloadCount = 0;
                foreach (string asset in toloadshown)
                {
                    toloadBuilder.AppendLine(asset);
                    toloadCount++;
                    if (toloadCount > lineLimit)
                    {
                        break;
                    }
                }
                toloadText.text = toloadBuilder.ToString();
            }
            timeElapsed += Time.deltaTime;
            newDotStatus = (int)(timeElapsed * 4 % 4);
            if (newDotStatus != dotStatus)
            {
                dotStatus = newDotStatus;
                switch ((int)(timeElapsed * 4 % 4))
                {
                    case 0:
                        Dot1.SetActive(false);
                        Dot2.SetActive(false);
                        Dot3.SetActive(false);
                        break;
                    case 1:
                        Dot1.SetActive(true);
                        Dot2.SetActive(false);
                        Dot3.SetActive(false);
                        break;
                    case 2:
                        Dot1.SetActive(true);
                        Dot2.SetActive(true);
                        Dot3.SetActive(false);
                        break;
                    case 3:
                        Dot1.SetActive(true);
                        Dot2.SetActive(true);
                        Dot3.SetActive(true);
                        break;
                }
            }
            yield return null;
        }
        Loaded.SetActive(false);
        Destroy(DLKuromon);
        Destroy(Loading);
        Destroy(Dot1);
        Destroy(Dot2);
        Destroy(Dot3);
        for (float i = 4.5f; i >= -4.5f; i--)
        {
            for (float j = i >= 1.5 ? -3f : -1.5f - i; j <= (i >= -1.5f ? 1.5f - i : 3f); j++)
            {
                float x = j;
                float y = i + j;
                StartCoroutine(FlipSceneChange(x, y, 0f, Mathf.Pow(2, 0.5f), 0.03f));
            }
            yield return new WaitForSeconds(0.03f);
        }
    }
    private IEnumerator FlipSceneChange(float x, float y, float wStart, float wEnd, float time)
    {
        GameObject sc = GameObject.Find(x.ToString() + "," + y.ToString());
        float timeElapsed = 0f;
        while (timeElapsed < time)
        {
            timeElapsed += Time.deltaTime;
            sc.transform.localRotation = new Quaternion(1f, 1f, 0f, Mathf.Lerp(wStart, wEnd, timeElapsed / time));
            yield return null;
        }
        sc.transform.localRotation = new Quaternion(1f, 1f, 0f, wEnd);
    }
    private bool Talking = false;
    private bool TalkQuickEnd = false;
    private bool WaitForClick = false;
    private List<string> Waiting = new List<string>();
    private int advScriptProgress = 0;
    private List<string> talkingChara = new List<string>();
    private List<string> highlightChara = new List<string>();
    private List<string> forceHighlight = new List<string>();
    private List<string> forceShading = new List<string>();
    private List<string> charaPriorityFirst = new List<string>();
    private List<string> charaPriorityMid = new List<string>();
    private List<string> charaPriorityLast = new List<string>();
    private string[] EffectPreset = new string[3];
    private bool textCanvasVisible = false;
    private bool nextCommand = true;
    private bool getInput = true;
    private bool ShakeStopping = false;
    private bool SEStopping = false;
    private bool VOICEStopping = false;
    private bool EffectSEMuted = false;
    private bool preRead = false;
    private Dictionary<int, int> charaShotPx = new Dictionary<int, int>{
        {-1,-999},{5,-555},{0,-444},{6,-333},{1,-222},{7,-111},{2,0},{8,111},{3,222},{9,333},{4,444},{10,555},{-2,999}
    };
    private Dictionary<int, string> charaFaceID = new Dictionary<int, string>{
        {0,"Default"},{1,"Joy"},{2,"Angry"},{3,"Sorrow"},{4,"Happy"},{5,"Shy"},{6,"Surprise"},{7,"Unique1"},{8,"Unique2"},{9,"Unique3"},{10,"Unique4"},{11,"Unique5"},{12,"Unique6"},{13,"Unique7"},{14,"Unique8"},{15,"Unique9"},{16,"Unique10"},{17,"Unique11"},{18,"Unique12"},{19,"Unique13"}
    };
    private Dictionary<int, string> ADVCategory = new Dictionary<int, string>{
        {1,"Story"},{2,"Event"},{3,"CharaEvent"},{4,"CrossEvent"},{5,"WeaponEvent"},{6,"Other"},{7,"Writer"},{9,"Custom"}
    };
    private Dictionary<int, float> ShakeScale = new Dictionary<int, float>{
        {0,2.5f},{1,7.5f},{2,20f}
    };
    private bool Playing = false;
    private bool JsonLoading = true;
    private bool StartLoading = true;
    private float Ease(float t, int EaseType)
    {
        switch (EaseType)
        {
            case 0: return t;
            case 1: return t * t;
            case 2: return -t * (t - 2);
            case 3: if (t < 0.5f) { return 2 * t * t; } else { return -2 * t * (t - 2) - 1; }
            case 4: return t * t * t;
            case 5: return t * (t * (t - 3) + 3);
            case 6: if (t < 0.5f) { return 4 * t * t * t; } else { return 4 * t * (t * (t - 3) + 3) - 3; }
            default: return t;
        }
    }
    private int[] CharaShots = new int[5] { 0, 1, 2, 3, 4 };
    private string[] CharaTargets = new string[5] { "-1", "-1", "-1", "-1", "-1" };
    private Dictionary<string, string> CharasExist = new Dictionary<string, string>();
    private Dictionary<string, int> CharasLayer = new Dictionary<string, int>();
    private List<string> Fading = new List<string>();
    private List<string> CharaFading = new List<string>();
    private List<string> CharaMoving = new List<string>();
    private List<string> CharaRotating = new List<string>();
    private List<string> CharaMotioning = new List<string>();
    private Dictionary<string[], GameObject> Emotioning = new Dictionary<string[], GameObject>();
    private Dictionary<string, List<GameObject>> Effecting = new Dictionary<string, List<GameObject>>();
    private List<GameObject> EffectEnding = new List<GameObject>();
    private Dictionary<string, GameObject> BGMPlaying = new Dictionary<string, GameObject>();
    private Dictionary<GameObject, string> SEPlaying = new Dictionary<GameObject, string>();
    private List<string> VOICEPlaying = new List<string>();
    private List<uint> BGScrolling = new List<uint>();
    private List<uint> BGScaling = new List<uint>();
    private List<uint> SpriteScaling = new List<uint>();
    private List<uint> SpritePosing = new List<uint>();
    private List<uint> SpriteFading = new List<uint>();
    private List<uint> SpriteColoring = new List<uint>();
    private List<Coroutine> autoWait = new List<Coroutine>();
    private List<GameObject> rubys = new List<GameObject>();
    private Dictionary<string, CharaProperties> charaPropertiesDict = new Dictionary<string, CharaProperties>();
    private Dictionary<uint, Dictionary<string, Coroutine>> bgCoroutinesDict = new Dictionary<uint, Dictionary<string, Coroutine>>();
    private Dictionary<uint, Dictionary<string, Coroutine>> spriteCoroutinesDict = new Dictionary<uint, Dictionary<string, Coroutine>>();
    private Dictionary<string, Dictionary<string, Coroutine>> charaCoroutinesDict = new Dictionary<string, Dictionary<string, Coroutine>>();
    private bool PlayingCaption = false;
    private bool WaitForClickCaption = false;
    private byte[] CaptionBGSprite = new byte[0];
    private float[] CaptionBGSpriteWH = new float[2] { 0f, 0f };
    private Dictionary<string, float[,]> CaptionPosScl = new Dictionary<string, float[,]> { { "BG", new float[3, 4] { { 0f, 0f, 1f, 1f }, { 0f, 0f, 1f, 1f }, { 0f, 0f, 1f, 1f } } }, { "Text", new float[3, 4] { { -80f, 0f, 1f, 1f }, { 0f, 0f, 1f, 1f }, { 80f, 0f, 1f, 1f } } } };
    private Dictionary<string, string[]> CaptionRGBA = new Dictionary<string, string[]> { { "BG", new string[3] { "#FFFFFF00", "#FFFFFFFF", "#FFFFFF00" } }, { "Text", new string[3] { "#FFFFFF00", "#FFFFFFFF", "#FFFFFF00" } } };
    private Dictionary<string, float[,]> CaptionSecDelay = new Dictionary<string, float[,]> { { "BG", new float[2, 2] { { 0.2f, 0 }, { 0.2f, 0f } } }, { "Text", new float[2, 2] { { 0.2f, 0.2f }, { 0.2f, 0f } } } };
    private Dictionary<string, int[]> CaptionCurveType = new Dictionary<string, int[]> { { "BG", new int[2] { 0, 0 } }, { "Text", new int[2] { 2, 1 } } };
    private string CaptionTextScript = "";
    private Coroutine DistortionLevelChangeCoroutine;
    private Coroutine BGDistortionCoroutine;
    private List<string> warpPreparing = new List<string>();
    private List<string> warpPrepared = new List<string>();
    private List<string> warpping = new List<string>();
    private int TextTagArg(string tag)
    {
        advtexttagarg_Params advtexttagarg_Params = advTextTagArg.m_Params.FirstOrDefault(param => param.m_ReferenceName == tag);
        if (advtexttagarg_Params == null)
        {
            return -1;
        }
        else { return advtexttagarg_Params.m_EnumID; }
    }
    private Dictionary<int, List<List<string>>> ParseScriptText(string text)
    {
        Dictionary<int, List<List<string>>> result = new Dictionary<int, List<List<string>>>();
        for (int i = 0; i < text.Length; i++) { result.Add(i, new List<List<string>>()); }
        int colorStart = 0;
        string color = "";
        int sizeStart = 0;
        int rubyStart = 0;
        int rubyStartIndex = 0;
        int rubyLine = 0;
        bool tagging;
        string ruby = "";
        string size = "";
        Regex regex = new(@"<([^>]+)>");
        MatchCollection matches = regex.Matches(text);
        foreach (Match match in matches)
        {
            string command;
            string[] commandList = new string[0];
            if (match.Groups[1].Value.ToString().Contains('='))
            {
                command = match.Groups[1].Value.ToString().Substring(0, match.Groups[1].Value.ToString().IndexOf('='));
                commandList = match.Groups[1].Value.ToString()[(command.Length + 1)..].Split(",");
            }
            else
            {
                command = match.Groups[1].Value.ToString();
            }
            switch (command)
            {
                case "mot":
                    result[match.Index].Add(new List<string> { "mot", commandList[0], commandList[1] });
                    break;
                case "waitmot":
                    result[match.Index].Add(new List<string> { "waitmot" });
                    break;
                case "wait":
                    result[match.Index].Add(new List<string> { "wait", commandList[0] });
                    break;
                case "voice":
                    result[match.Index].Add(new List<string> { "voice", commandList[0], commandList[1] });
                    break;
                case "emo":
                    result[match.Index].Add(new List<string> { "emo", commandList[0], commandList[1] });
                    break;
                case "face":
                    //if(commandList[1]=="楽」"){
                    //    result[match.Index].Add(new List<string>{"face",commandList[0],"楽"});
                    //}else{result[match.Index].Add(new List<string>{"face",commandList[0],commandList[1]});}
                    result[match.Index].Add(new List<string> { "face", commandList[0], commandList[1] });
                    break;
                case "color":
                    colorStart = match.Index + match.Length;
                    color = commandList[0];
                    break;
                case "/color":
                    for (int i = colorStart; i < match.Index; i++)
                    {
                        result[i].Add(new List<string> { "color", color });
                    }
                    break;
                case "se":
                    result[match.Index].Add(new List<string> { "se", commandList[0] });
                    break;
                case "mov":
                    result[match.Index].Add(new List<string> { "mov", commandList[0], commandList[1], commandList[2], commandList[3] });
                    break;
                case "waitmov":
                    result[match.Index].Add(new List<string> { "waitmov", commandList[0] });
                    break;
                case "ruby ":
                    rubyStart = match.Index;
                    rubyStartIndex = 0;
                    rubyLine = 0;
                    tagging = false;
                    for (int i = 0; i < match.Index; i++)
                    {
                        if (text[i] == '<')
                        {
                            tagging = true;
                        }
                        else if (text[i] == '>')
                        {
                            tagging = false;
                        }
                        if (!tagging)
                        {
                            if (text[i] == '\n')
                            {
                                rubyStartIndex = 0;
                                rubyLine++;
                            }
                            else
                            {
                                rubyStartIndex++;
                            }
                        }
                    }
                    rubyStartIndex++;
                    ruby = commandList[0][1..];
                    break;
                case "/ruby":
                    int rubyEnd = 0;
                    int rubyEndLine = 0;
                    tagging = false;
                    for (int i = 0; i < match.Index; i++)
                    {
                        if (text[i] == '<')
                        {
                            tagging = true;
                        }
                        else if (text[i] == '>')
                        {
                            tagging = false;
                        }
                        else if (!tagging)
                        {
                            if (text[i] == '\n')
                            {
                                rubyEnd = 0;
                                rubyEndLine++;
                            }
                            else
                            {
                                rubyEnd++;
                            }
                        }
                    }
                    result[rubyStart].Add(new List<string> { "ruby", ruby, rubyStartIndex.ToString(), rubyLine.ToString(), rubyEnd.ToString(), rubyEndLine.ToString() });
                    break;
                case "facet":
                    result[match.Index].Add(new List<string> { "face", commandList[0], commandList[1] });
                    break;
                case "pose":
                    result[match.Index].Add(new List<string> { "pose", commandList[0], commandList[1] });
                    break;
                case "shake":
                    result[match.Index].Add(new List<string> { "shake", commandList[0], commandList[1] });
                    break;
                case "voice ":
                    result[match.Index].Add(new List<string> { "voice", commandList[0], commandList[1] });
                    break;
                case "face ":
                    result[match.Index].Add(new List<string> { "face", commandList[0], commandList[1] });
                    break;
                case "emo ":
                    result[match.Index].Add(new List<string> { "emo", commandList[0], commandList[1] });
                    break;
                case "mot ":
                    result[match.Index].Add(new List<string> { "mot", commandList[0], commandList[1] });
                    break;
                case "wait ":
                    result[match.Index].Add(new List<string> { "wait", commandList[0] });
                    break;
                case "size":
                    sizeStart = match.Index + match.Length;
                    size = commandList[0];
                    break;
                case "/size":
                    for (int i = sizeStart; i < match.Index; i++)
                    {
                        result[i].Add(new List<string> { "size", size });
                    }
                    break;
                case "ruby":
                    rubyStart = match.Index;
                    rubyStartIndex = 0;
                    rubyLine = 0;
                    tagging = false;
                    for (int i = 0; i < match.Index; i++)
                    {
                        if (text[i] == '<')
                        {
                            tagging = true;
                        }
                        else if (text[i] == '>')
                        {
                            tagging = false;
                        }
                        else if (!tagging)
                        {
                            if (text[i] == '\n')
                            {
                                rubyStartIndex = 0;
                                rubyLine++;
                            }
                            else
                            {
                                rubyStartIndex++;
                            }
                        }
                    }
                    rubyStartIndex++;
                    ruby = commandList[0];
                    break;
                default:
                    break;
            }
        }
        return result;
    }
    private advcharacterlist_Params GetCharaParams(string ADVCharaID)
    {
        if (ADVCharaID == null){ return null; }
        charaParamsLookup.TryGetValue(ADVCharaID, out advcharacterlist_Params result);
        return result;
    }
    private int GetCharaIndex(string ADVCharaID)
    {
        if (!charaParamsLookup.TryGetValue(ADVCharaID, out advcharacterlist_Params advcharacterlist_params))
        {
            return -1;
        }
        return advCharacterList.m_Params.IndexOf(advcharacterlist_params);
    }
    private int GetCharaMaxIndex()
    {
        return advCharacterList.m_Params.Count;
    }
    private advclist_Params_Data GetCharaParamsPose(string ADVCharaID)
    {
        return GetCharaParams(ADVCharaID).m_Datas.First(param => param.m_PoseID == charaPropertiesDict[ADVCharaID].PoseID);
    }
    private int GetCharaParamsPoseFaceRefernceImageType(string ADVCharaID)
    {
        return GetCharaParams(ADVCharaID).m_Datas.First(param => param.m_PoseID == charaPropertiesDict[ADVCharaID].PoseID).m_FaceReferenceImageType;
    }
    private void CreateStandpic(string ADVCharaID)
    {
        isUpdateCharaFace.Add(ADVCharaID);
        isUpdateCharaFaceTexture.Add(ADVCharaID);
        isUpdateCharaPose.Add(ADVCharaID);
        isUpdateCharaPosition.Add(ADVCharaID);
        isUpdateCharaFade.Add(ADVCharaID);
        isUpdateHighlight = true;
        isUpdatePriority = true;
        charaPropertiesDict[ADVCharaID].FaceID = 0;
        charaPropertiesDict[ADVCharaID].PoseID = 0;
        charaPropertiesDict[ADVCharaID].MotOffset = new Vector2(0f, 0f);
        charaPropertiesDict[ADVCharaID].ShakeOffset = new Vector2(0f, 0f);
        charaPropertiesDict[ADVCharaID].Scale = 1f;
        charaPropertiesDict[ADVCharaID].Angle = 0f;
        int layerID = -1;
        if (CharasExist.Keys.Contains(ADVCharaID))
        {
            foreach (Coroutine coroutine in charaCoroutinesDict[ADVCharaID].Values)
            {
                if (coroutine == null) { continue; }
                StopCoroutine(coroutine);
            }
            CharaMoving.RemoveAll(item => item == ADVCharaID);
            CharaRotating.RemoveAll(item => item == ADVCharaID);
            CharaMotioning.RemoveAll(item => item == ADVCharaID);
            CharaFading.RemoveAll(item => item == ADVCharaID);
            isUpdateCharaDestroy.Remove(ADVCharaID);
            charaCoroutinesDict[ADVCharaID] = new Dictionary<string, Coroutine>{
                {"fade",null},{"move",null},{"mot",null},{"rotate",null},{"shake",null},{"transparency",null},{"destroy",null},
            };
            layerID = CharasLayer[ADVCharaID];
        }
        else
        {
            CharasExist.Add(ADVCharaID, GetCharaParams(ADVCharaID).m_DisplayName);
            List<int> existingLayers = new List<int>(CharasLayer.Values);
            existingLayers.Sort();
            for (int i = 0; i < existingLayers.Count; i++)
            {
                if (existingLayers[i] != i)
                {
                    layerID = i;
                    break;
                }
            }
            if (layerID == -1)
            {
                layerID = existingLayers.Count;
            }
            CharasLayer.Add(ADVCharaID, layerID);
        }
        string layerName = "Chara" + layerID.ToString();
        GameObject chara;
        chara = FindCached(ADVCharaID);
        if (chara == null)
        {
            chara = new GameObject(ADVCharaID);
            CacheGameObject(ADVCharaID, chara);
        }
        Texture2D texture = new Texture2D(0, 0);
        texture.wrapMode = TextureWrapMode.Clamp;
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, 0, 0), new Vector2(0.5f, 0.5f), 1, 0, SpriteMeshType.FullRect);
        SpriteRenderer spriteRenderer = chara.GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            spriteRenderer = chara.AddComponent<SpriteRenderer>();
        }
        spriteRenderer.sprite = sprite;
        spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
        spriteRenderer.maskInteraction = SpriteMaskInteraction.VisibleOutsideMask;
        spriteRenderer.sortingOrder = 0;
        chara.layer = layerID + 10;
        chara.transform.SetParent(canvas.transform);
        GameObject charaMask;
        charaMask = FindCached(ADVCharaID + "_Mask");
        if (charaMask == null)
        {
            charaMask = new GameObject(ADVCharaID + "_Mask");
            CacheGameObject(ADVCharaID + "_Mask", charaMask);
        }
        SpriteMask spriteMask = charaMask.GetComponent<SpriteMask>();
        if (spriteMask == null)
        {
            spriteMask = charaMask.AddComponent<SpriteMask>();
        }
        spriteMask.sprite = sprite;
        spriteMask.isCustomRangeActive = true;
        spriteMask.frontSortingOrder = 0;
        spriteMask.backSortingOrder = -1;
        RectTransform rectTransform = charaMask.GetComponent<RectTransform>();
        if (rectTransform == null)
        {
            rectTransform = charaMask.AddComponent<RectTransform>();
        }
        rectTransform.anchorMin = new Vector2(0f, 1f);
        rectTransform.anchorMax = new Vector2(0f, 1f);
        rectTransform.pivot = new Vector2(0.5f, 0.5f);
        rectTransform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        rectTransform.localScale = new Vector3(1f, 1f, 1f);
        charaMask.layer = layerID + 10;
        charaMask.transform.SetParent(chara.transform);
        GameObject charaFace;
        charaFace = FindCached(ADVCharaID + "_Face");
        if (charaFace == null)
        {
            charaFace = new GameObject(ADVCharaID + "_Face");
            CacheGameObject(ADVCharaID + "_Face", charaFace);
        }
        SpriteRenderer faceRenderer = charaFace.GetComponent<SpriteRenderer>();
        if (faceRenderer == null)
        {
            faceRenderer = charaFace.AddComponent<SpriteRenderer>();
        }
        faceRenderer.sprite = sprite;
        faceRenderer.color = new Color(1f, 1f, 1f, 0f);
        faceRenderer.sortingOrder = 0;
        rectTransform = charaFace.GetComponent<RectTransform>();
        if (rectTransform == null)
        {
            rectTransform = charaFace.AddComponent<RectTransform>();
        }
        rectTransform.anchorMin = new Vector2(0f, 1f);
        rectTransform.anchorMax = new Vector2(0f, 1f);
        rectTransform.pivot = new Vector2(0.5f, 0.5f);
        rectTransform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        rectTransform.localScale = new Vector3(1f, 1f, 1f);
        charaFace.layer = layerID + 10;
        charaFace.transform.SetParent(chara.transform);
        rectTransform = chara.GetComponent<RectTransform>();
        if (rectTransform == null)
        {
            rectTransform = chara.AddComponent<RectTransform>();
        }
        rectTransform.anchorMin = new Vector2(0.5f, 0f);
        rectTransform.anchorMax = new Vector2(0.5f, 0f);
        rectTransform.pivot = new Vector2(0.5f, 0f);
        rectTransform.localScale = new Vector3(1f, 1f, 1f);
        rectTransform.anchoredPosition = new Vector3(0f, 10000f, 0f);
        if (!charaPriorityFirst.Contains(ADVCharaID) && !charaPriorityMid.Contains(ADVCharaID) && !charaPriorityLast.Contains(ADVCharaID))
        {
            //charaPriorityMid.Insert(0,ADVCharaID);
            charaPriorityMid.Add(ADVCharaID);
        }
        Camera camera = cameras[layerID];
        RenderTexture renderTexture = new RenderTexture(4000, 2250, 24);
        camera.targetTexture = renderTexture;
        if (FindCached(ADVCharaID + "_RT") != null)
        {
            FindCached(ADVCharaID + "_RT").GetComponent<MeshRenderer>().material.SetTexture(_MainTex, camera.targetTexture);
        }
        else
        {
            GameObject renderTextureChara = new GameObject(ADVCharaID + "_RT");
            CacheGameObject(ADVCharaID + "_RT", renderTextureChara);
            renderTextureChara.transform.SetParent(renderTextureObj.transform);
            renderTextureChara.AddComponent<MeshRenderer>().material = new Material(Shader.Find("CustomShader_COMMON"));
            renderTextureChara.GetComponent<MeshRenderer>().material.SetTexture(_MainTex, camera.targetTexture);
            renderTextureChara.GetComponent<MeshRenderer>().material.SetTexture("_Texture_Noise", Resources.Load<Texture2D>("noise-good"));
            renderTextureChara.GetComponent<MeshRenderer>().material.SetVector(_NoiseTextureParam, new Vector4(0, 0, 0.5f, 0.5f));
            renderTextureChara.AddComponent<MeshFilter>().mesh = CreateMesh(1333.33f, 750f, new Vector2(0.5f, 0.5f));
            rectTransform = renderTextureChara.AddComponent<RectTransform>();
            rectTransform.localScale = new Vector3(1f, 1f, 1f);
            rectTransform.anchoredPosition = new Vector3(0f, 0f, 0f);
            renderTextureChara.layer = LayerMask.NameToLayer("Chara");
        }
    }
    private void CharaSetPosition(string ADVCharaID, float x, float y)
    {
        if (charaCoroutinesDict[ADVCharaID]["move"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["move"]); }
        charaPropertiesDict[ADVCharaID].Position = new Vector2(x, y);
        isUpdateCharaPosition.Add(ADVCharaID);
    }
    private void Highlight(string ADVCharaID)
    {
        GameObject chara = FindCached(ADVCharaID);
        if (chara == null) { return; }
        SpriteRenderer sr = chara.GetComponent<SpriteRenderer>();
        sr.color = new Color(1f, 1f, 1f, sr.color.a);
        FindCached(chara.name + "_Face").GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, sr.color.a);
    }
    private void Shading(string ADVCharaID)
    {
        GameObject chara = FindCached(ADVCharaID);
        if (chara == null) { return; }
        SpriteRenderer sr = chara.GetComponent<SpriteRenderer>();
        sr.color = new Color(0.5f, 0.5f, 0.5f, sr.color.a);
        FindCached(chara.name + "_Face").GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f, sr.color.a);
    }
    private void ForwardChara(string ADVCharaID)
    {
        if (charaPriorityFirst.Contains(ADVCharaID))
        {
            charaPriorityFirst.Remove(ADVCharaID);
            charaPriorityFirst.Add(ADVCharaID);
        }
        if (charaPriorityMid.Contains(ADVCharaID))
        {
            charaPriorityMid.Remove(ADVCharaID);
            charaPriorityMid.Add(ADVCharaID);
        }
        if (charaPriorityLast.Contains(ADVCharaID))
        {
            charaPriorityLast.Remove(ADVCharaID);
            charaPriorityLast.Add(ADVCharaID);
        }
    }
    private Coroutine CreateEffect(string effectID, int StandPosition, float X, float Y, float Rotate, bool isCharaBehind, bool isLoop, float multiple)
    {
        return StartCoroutine(SetEffect(effectID, charaShotPx[StandPosition] + X, Y, Rotate, isCharaBehind, isLoop, multiple, 0f, -500, EffectSEMuted));
    }
    private Coroutine CreateEffectChara(string effectID, string ADVCharaID, int CharaAnchor, float X, float Y, float Rotate, bool isCharaBehind, bool isLoop, float multiple)
    {
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        advcharacterlist_Params param = GetCharaParams(ADVCharaID);
        advclist_Params_Data Pose = GetCharaParamsPose(ADVCharaID);
        Vector2 Anchorxy = new Vector2(0f, 0f);
        Texture2D texture;
        int FaceReferenceImageType = GetCharaParamsPoseFaceRefernceImageType(ADVCharaID);
        if (FaceReferenceImageType == 0)
        {
            texture = webTexture[param.m_ResourceBaseName + "_StandPic_" + Pose.m_PoseID];
        }
        else { texture = webTexture[param.m_ResourceBaseName + "_Face_" + Pose.m_PoseID + "_" + charaFaceID[charaProperties.FaceID]]; }
        Anchorxy += new Vector2(Pose.m_OffsetX + charaProperties.Position.x, Pose.m_OffsetY + charaProperties.Position.y) + new Vector2(-texture.width / 2f, texture.height * (1 - Pose.m_FaceReferenceImageType * Pose.m_FacePivotY));
        switch (CharaAnchor)
        {
            case 0:
                Anchorxy += new Vector2(texture.width / 2f, -(texture.height * (1 - Pose.m_FaceReferenceImageType * Pose.m_FacePivotY) + Pose.m_OffsetY) / 2f);
                break;
            case 1:
                Anchorxy += new Vector2(Pose.m_FaceX, -Pose.m_FaceY);
                break;
            case 2:
                Anchorxy += new Vector2(texture.width / 2f + Pose.m_FootOffsetX, -texture.height * (1 - Pose.m_FaceReferenceImageType * Pose.m_FacePivotY) - Pose.m_OffsetY + Pose.m_FootOffsetY);
                break;
        }
        return StartCoroutine(SetEffect(effectID, X + Anchorxy[0], Y + Anchorxy[1], Rotate, isCharaBehind, isLoop, multiple, 0f, -400, EffectSEMuted));
    }
    private Coroutine CreateEffectScreen(string effectID, int ScreenAnchor, float X, float Y, float Rotate, bool isCharaBehind, bool isLoop, float multiple)
    {
        float AnchorX = 0;
        float AnchorY = 0;
        switch (ScreenAnchor)
        {
            case 0:
                AnchorX = 0;
                AnchorY = 0;
                break;
            case 1:
                AnchorX = 0;
                AnchorY = 375;
                break;
            case 2:
                AnchorX = 0;
                AnchorY = -375;
                break;
            case 10:
                AnchorX = 0;
                AnchorY = 0;
                break;
        }
        return StartCoroutine(SetEffect(effectID, AnchorX + X, AnchorY + Y, Rotate, isCharaBehind, isLoop, multiple, 0.5f, -300, EffectSEMuted));
    }
    private IEnumerator CharaMoveTo(string ADVCharaID, float x, float y, float sec, int CurveType)
    {
        CharaMoving.Add(ADVCharaID);
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        Vector2 start = charaProperties.Position;
        float timeElapsed = 0f;
        while (timeElapsed < sec)
        {
            timeElapsed += Time.deltaTime;
            float x_axis = Mathf.Lerp(start[0], x, Ease(timeElapsed / sec, CurveType));
            float y_axis = Mathf.Lerp(start[1], y, Ease(timeElapsed / sec, CurveType));
            charaPropertiesDict[ADVCharaID].Position = new Vector2(x_axis, y_axis);
            isUpdateCharaPosition.Add(ADVCharaID);
            yield return null;
        }
        charaPropertiesDict[ADVCharaID].Position = new Vector2(x, y);
        isUpdateCharaPosition.Add(ADVCharaID);
        CharaMoving.RemoveAll(item => item == ADVCharaID);
    }
    private IEnumerator CharaFade(string ADVCharaID, float start, float end, float sec)
    {
        CharaFading.Add(ADVCharaID);
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        float timeElapsed = 0f;
        while (timeElapsed < sec)
        {
            timeElapsed += Time.deltaTime;
            charaProperties.Fade = Mathf.Lerp(start, end, Ease(timeElapsed / sec, 0));
            isUpdateCharaFade.Add(ADVCharaID);
            yield return null;
        }
        charaProperties.Fade = end;
        isUpdateCharaFade.Add(ADVCharaID);
        CharaFading.RemoveAll(item => item == ADVCharaID);
    }
    private IEnumerator DestroyAfterAnimation(string ADVCharaID, List<Coroutine> coroutines)
    {
        isUpdateHighlight = true;
        if (talkingChara.Contains(ADVCharaID))
        {
            talkingChara.Remove(ADVCharaID);
        }
        foreach (Coroutine coroutine in coroutines)
        {
            yield return coroutine;
        }
        isUpdateCharaDestroy.Add(ADVCharaID);
    }
    private IEnumerator ImageFade(string RGBAStart, string RGBAEnd, float Sec, int CurveType)
    {
        ColorUtility.TryParseHtmlString(RGBAStart, out Color colorStart);
        ColorUtility.TryParseHtmlString(RGBAEnd, out Color colorEnd);
        Fading.Add(RGBAStart);
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            timeElapsed += Time.deltaTime;
            float r = Mathf.Lerp(colorStart.r, colorEnd.r, Ease(timeElapsed / Sec, CurveType));
            float g = Mathf.Lerp(colorStart.g, colorEnd.g, Ease(timeElapsed / Sec, CurveType));
            float b = Mathf.Lerp(colorStart.b, colorEnd.b, Ease(timeElapsed / Sec, CurveType));
            float a = Mathf.Lerp(colorStart.a, colorEnd.a, Ease(timeElapsed / Sec, CurveType));
            imageSpriteRenderer.color = new Color(r, g, b, a);
            yield return null;
        }
        imageSpriteRenderer.color = colorEnd;
        Fading.Remove(RGBAStart);
    }
    private IEnumerator ImageFadeIn(string RGBA, float Sec)
    {
        ColorUtility.TryParseHtmlString(RGBA, out Color color);
        Fading.Add(RGBA);
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            timeElapsed += Time.deltaTime;
            float a = Mathf.Lerp(1f, 0f, timeElapsed / Sec);
            imageSpriteRenderer.color = new Color(color.r, color.g, color.b, a);
            yield return null;
        }
        imageSpriteRenderer.color = new Color(color.r, color.g, color.b, 0f);
        Fading.Remove(RGBA);
    }
    private IEnumerator ImageFadeOut(string RGBA, float Sec)
    {
        ColorUtility.TryParseHtmlString(RGBA, out Color color);
        Fading.Add(RGBA);
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            timeElapsed += Time.deltaTime;
            float a = Mathf.Lerp(0f, 1f, timeElapsed / Sec);
            imageSpriteRenderer.color = new Color(color.r, color.g, color.b, a);
            yield return null;
        }
        imageSpriteRenderer.color = new Color(color.r, color.g, color.b, 1f);
        Fading.Remove(RGBA);
    }
    private IEnumerator CharaTransparencyChange(string ADVCharaID, float aEnd, float Sec, int CurveType)
    {
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        float aStart = charaProperties.Transparency;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            timeElapsed += Time.deltaTime;
            charaProperties.Transparency = Mathf.Lerp(aStart, aEnd, Ease(timeElapsed / Sec, CurveType));
            isUpdateCharaTransparency.Add(ADVCharaID);
            yield return null;
        }
        charaProperties.Transparency = aEnd;
        isUpdateCharaTransparency.Add(ADVCharaID);
    }
    private IEnumerator CharaRotateChange(string ADVCharaID, float PivotX, float PivotY, float Angle, float Sec, int CurveType)
    {
        CharaRotating.Add(ADVCharaID);
        GameObject chara = FindCached(ADVCharaID);
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        float angleStart = charaProperties.Angle;
        float timeElapsed = 0f;
        advcharacterlist_Params param = GetCharaParams(ADVCharaID);
        advclist_Params_Data Pose = GetCharaParamsPose(ADVCharaID);
        Texture2D texture;
        int FaceReferenceImageType = GetCharaParamsPoseFaceRefernceImageType(ADVCharaID);
        if (FaceReferenceImageType == 0)
        {
            texture = webTexture[param.m_ResourceBaseName + "_StandPic_" + Pose.m_PoseID];
        }
        else { texture = webTexture[param.m_ResourceBaseName + "_Face_" + Pose.m_PoseID + "_" + charaFaceID[charaProperties.FaceID]]; }
        charaProperties.RotateCenter = new Vector2((PivotX - 0.5f) * texture.width, (1 - PivotY) * texture.height);
        while (timeElapsed < Sec)
        {
            timeElapsed += Time.deltaTime;
            float angle = Mathf.Lerp(angleStart, Angle, Ease(timeElapsed / Sec, CurveType));
            charaProperties.Angle = angle;
            isUpdateCharaPosition.Add(ADVCharaID);
            yield return null;
        }
        charaProperties.Angle = Angle;
        isUpdateCharaPosition.Add(ADVCharaID);
        CharaRotating.RemoveAll(item => item == ADVCharaID);
    }
    private IEnumerator CharaRotateResetChange(string ADVCharaID, float Sec)
    {
        CharaRotating.Add(ADVCharaID);
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        float angleStart = charaProperties.Angle;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            timeElapsed += Time.deltaTime;
            float angle = Mathf.Lerp(angleStart, 0f, Ease(timeElapsed / Sec, 0));
            charaProperties.Angle = angle;
            isUpdateCharaPosition.Add(ADVCharaID);
            yield return null;
        }
        charaProperties.Angle = 0f;
        isUpdateCharaPosition.Add(ADVCharaID);
        CharaRotating.Remove(ADVCharaID);
    }
    private IEnumerator WaitForCharaRotate(string ADVCharaID)
    {
        Waiting.Add("WaitForCharaRotate1");
        yield return null;
        while (CharaRotating.Contains(ADVCharaID))
        {
            yield return null;
        }
        Waiting.Remove("WaitForCharaRotate1");
    }
    private IEnumerator WaitForCharaRotate()
    {
        Waiting.Add("WaitForCharaRotate2");
        yield return null;
        while (CharaRotating.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForCharaRotate2");
    }
    private IEnumerator WaitForSec(float sec)
    {
        Waiting.Add("WaitForSec");
        yield return null;
        float timeElapsed = 0f;
        while (timeElapsed < sec)
        {
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        Waiting.Remove("WaitForSec");
    }
    private IEnumerator WaitForFade()
    {
        Waiting.Add("WaitForFade");
        yield return null;
        while (Fading.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForFade");
    }
    private IEnumerator WaitForMotion()
    {
        Waiting.Add("WaitForMotion");
        yield return null;
        while (CharaMotioning.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForMotion");
    }
    private IEnumerator WaitForCharaMove()
    {
        Waiting.Add("WaitForCharaMove");
        yield return null;
        while (CharaMoving.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForCharaMove");
    }
    private IEnumerator WaitForCharaFade()
    {
        Waiting.Add("WaitForCharaFade");
        yield return null;
        while (CharaFading.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForCharaFade");
    }
    private IEnumerator WaitForBGScroll(uint ID)
    {
        Waiting.Add("WaitForBGScroll");
        yield return null;
        while (BGScrolling.Contains(ID))
        {
            yield return null;
        }
        Waiting.Remove("WaitForBGScroll");
    }
    private IEnumerator WaitForBGScale(uint ID)
    {
        Waiting.Add("WaitForBGScale");
        yield return null;
        while (BGScaling.Contains(ID))
        {
            yield return null;
        }
        Waiting.Remove("WaitForBGScale");
    }
    private IEnumerator WaitForSpriteScale(uint ID)
    {
        Waiting.Add("WaitForSpriteScale");
        yield return null;
        while (SpriteScaling.Contains(ID))
        {
            yield return null;
        }
        Waiting.Remove("WaitForSpriteScale");
    }
    private IEnumerator WaitForSpritePos(uint ID)
    {
        Waiting.Add("WaitForSpritePos1");
        yield return null;
        while (SpritePosing.Contains(ID))
        {
            yield return null;
        }
        Waiting.Remove("WaitForSpritePos1");
    }
    private IEnumerator WaitForSpritePos()
    {
        Waiting.Add("WaitForSpritePos2");
        yield return null;
        while (SpritePosing.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForSpritePos2");
    }
    private IEnumerator WaitForSpriteFade(uint ID)
    {
        Waiting.Add("WaitForSpriteFade1");
        yield return null;
        while (SpriteFading.Contains(ID))
        {
            yield return null;
        }
        Waiting.Remove("WaitForSpriteFade1");
    }
    private IEnumerator WaitForSpriteFade()
    {
        Waiting.Add("WaitForSpriteFade2");
        yield return null;
        while (SpriteFading.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForSpriteFade2");
    }
    private IEnumerator WaitForSpriteColor(uint ID)
    {
        Waiting.Add("WaitForSpriteColor1");
        yield return null;
        while (SpriteColoring.Contains(ID))
        {
            yield return null;
        }
        Waiting.Remove("WaitForSpriteColor1");
    }
    private IEnumerator WaitForSpriteColor()
    {
        Waiting.Add("WaitForSpriteColor2");
        yield return null;
        while (SpriteColoring.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForSpriteColor2");
    }
    private IEnumerator WaitForSE()
    {
        Waiting.Add("WaitForSE");
        yield return null;
        while (SEPlaying.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForSE");
    }
    private IEnumerator WaitForVOICE()
    {
        Waiting.Add("WaitForVOICE");
        yield return null;
        while (VOICEPlaying.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForVOICE");
    }
    private IEnumerator WaitForWarpPrepare()
    {
        Waiting.Add("WaitForWarpPrepare");
        yield return null;
        while (warpPreparing.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForWarpPrepare");
    }
    private IEnumerator WaitForWarp()
    {
        Waiting.Add("WaitForWarp");
        yield return null;
        while (warpping.Count > 0)
        {
            yield return null;
        }
        Waiting.Remove("WaitForWarp");
    }
    private IEnumerator Talk(advscripttext_Params param, bool isEmpty)
    {
        if (!QuickPlay) { Debug.Log(param.m_text); }
        Talking = true;
        if (!textCanvasVisible)
        {
            if (CanvasMoveCoroutine != null) { StopCoroutine(CanvasMoveCoroutine); }
            CanvasMoveCoroutine = StartCoroutine(ToggleCanvas(true));
            textCanvasVisible = true;
        }
        Transform labelTransform = textCanvas.transform.Find("ADVTalkerLabelBG");
        hasCharaName = !isEmpty;
        Transform textTransform = textCanvas.transform.Find("Text");
        GameObject textObj = textTransform.gameObject;
        Text text = textObj.GetComponent<Text>();
        Transform nameTransform = textCanvas.transform.Find("Name");
        GameObject nameObj = nameTransform.gameObject;
        Text name = nameObj.GetComponent<Text>();
        bool tagging = false;
        Dictionary<int, List<List<string>>> parsed = ParseScriptText(param.m_text);
        yield return null;
        if (isEmpty)
        {
            name.text = "";
        }
        else
        {
            if (param.m_charaName.Contains('$'))
            {
                name.text = param.m_charaName[..param.m_charaName.IndexOf('$')];
            }
            else if (GetCharaParams(param.m_charaName) != null)
            {
                name.text = GetCharaParams(param.m_charaName).m_DisplayName;
            }
            else
            {
                name.text = param.m_charaName;
            }
        }
        int nameOffset = name.text.Length < 6 ? 0 : (18 * (name.text.Length - 6) + 8);
        nameTransform.localPosition = new Vector3(-379f + nameOffset, 105.5f, 0f);
        labelTransform.gameObject.GetComponent<RectTransform>().localPosition = new Vector3(-367f + nameOffset, 104f, 0f);
        SpriteRenderer labelSR = labelTransform.gameObject.GetComponent<SpriteRenderer>();
        labelSR.size = new Vector2(437f + nameOffset * 2, 69f);
        labelSR.color = new Color(1f, 1f, 1f, isEmpty ? 0 : textObj.GetComponent<CanvasGroup>().alpha);
        foreach (GameObject ruby in rubys)
        {
            Destroy(ruby);
        }
        rubys = new List<GameObject>();
        text.text = "";
        for (int i = 0; i < param.m_text.Length; i++)
        {
            if (param.m_text[i] == '<')
            {
                tagging = true;
                foreach (List<string> command in parsed[i])
                {
                    switch (command[0])
                    {
                        case "mot":
                            CharaMot(command[1], command[2]);
                            break;
                        case "waitmot":
                            while (CharaMotioning.Count > 0 && !TalkQuickEnd)
                            {
                                yield return null;
                            }
                            break;
                        case "mov":
                            CharaMove(command[1], TextTagArg(command[2]), 0, 0, float.Parse(command[3]), TextTagArg(command[4]));
                            break;
                        case "waitmov":
                            while (CharaMoving.Contains(command[1]) && !TalkQuickEnd)
                            {
                                yield return null;
                            }
                            break;
                        case "wait":
                            float timeElapsed = 0f;
                            while (timeElapsed < float.Parse(command[1]) && !TalkQuickEnd)
                            {
                                timeElapsed += Time.deltaTime;
                                yield return null;
                            }
                            break;
                        case "emo":
                            CharaEmotion(command[1], command[2], 0);
                            break;
                        case "face":
                            CharaFace(command[1], TextTagArg(command[2]));
                            break;
                        case "pose":
                            CharaPose(command[1], command[2]);
                            break;
                        case "shake":
                            Shake(TextTagArg(command[1]), float.Parse(command[2]));
                            break;
                        case "voice":
                            List<string> voicePaths = new List<string>();
                            advcharacterlist_Params charaParams = GetCharaParams(command[1]);
                            if (charaParams == null) { continue; }
                            string voiceName = command[1] + "_" + command[2];
                            string voicePathBase = "";
                            if (charaParams.m_CueSheet != "")
                            {
                                voicePathBase = charaParams.m_CueSheet + @"\" + command[2] + "_";
                            }
                            else if (charaParams.m_NamedType != -1)
                            {
                                string charaResourceName = advCharaVoiceLabel.m_Params.First(param => param.m_NamedType == charaParams.m_NamedType).m_VoiceLabel;
                                voicePathBase = charaResourceName + @"\" + command[2] + "_";
                            }
                            for (int j = 0; j < 100; j++)
                            {
                                if (webAudio.ContainsKey(voicePathBase + j.ToString("D2")))
                                {
                                    voicePaths.Add(j.ToString("D2"));
                                }
                                else { break; }
                            }
                            System.Random random = new System.Random();
                            string voicePath = voicePathBase + voicePaths[random.Next(voicePaths.Count)];
                            GameObject voice = new GameObject(voiceName);
                            voice.transform.SetParent(Audios.transform);
                            AudioSource audioSource = voice.AddComponent<AudioSource>();
                            voice.transform.position = new Vector3(-1000f, 0f, 0f);
                            audioSource.clip = webAudio[voicePath];
                            autoWait.Add(StartCoroutine(PlayTalkVoice(voice)));
                            break;
                        case "se":
                            GameObject SE = new GameObject(command[1]);
                            AudioSource audioSourceText = SE.AddComponent<AudioSource>();
                            string SEPath = command[1];
                            SE.transform.position = new Vector3(0f, 8f, 0f);
                            audioSourceText.clip = webAudio[SEPath];
                            StartCoroutine(PlaySEFade(SE));
                            break;
                        case "ruby":
                            GameObject ruby = new GameObject("ruby");
                            rubys.Add(ruby);
                            ruby.transform.SetParent(textCanvas.transform);
                            RectTransform rubyTransform = ruby.AddComponent<RectTransform>();
                            rubyTransform.sizeDelta = new Vector2(900f, 96f);
                            rubyTransform.localScale = new Vector3(1f, 1f, 1f);
                            Text rubyText = ruby.AddComponent<Text>();
                            rubyText.alignment = TextAnchor.UpperCenter;
                            rubyText.font = font;
                            rubyText.fontSize = 16;
                            rubyText.lineSpacing = lineSpacing[globalFont];
                            rubyText.color = new Color(0.4235294f, 0.2627451f, 0.2117647f, 1f);
                            rubyText.text = command[1];
                            CanvasGroup rubyGroup = ruby.AddComponent<CanvasGroup>();
                            rubyGroup.alpha = 1f;
                            if (command[3] == "0")
                            {
                                rubyTransform.localPosition = new Vector3(-438f + (int.Parse(command[2]) + int.Parse(command[4])) * 18f, 16f, 0f);
                            }
                            else
                            {
                                rubyTransform.localPosition = new Vector3(-438f + (int.Parse(command[2]) + int.Parse(command[4])) * 18f, -42f, 0f);
                            }
                            break;
                    }
                }
            }
            if (tagging)
            {
                if (param.m_text[i] == '>')
                {
                    tagging = false;
                }
            }
            else
            {
                bool hascolor = false, hassize = false;
                if (parsed[i].Count > 0)
                {
                    foreach (List<string> command in parsed[i])
                    {
                        switch (command[0])
                        {
                            case "color":
                                text.text += "<color=" + command[1] + ">";
                                hascolor = true;
                                break;
                            case "size":
                                text.text += "<size=" + command[1] + ">";
                                hassize = true;
                                break;
                            default:
                                break;
                        }
                    }
                    text.text += param.m_text[i];
                    if (hascolor) { text.text += "</color>"; }
                    if (hassize) { text.text += "</size>"; }
                }
                else { text.text += param.m_text[i]; }
                if (!TalkQuickEnd)
                {
                    switch (globalFont)
                    {
                        case "ja": yield return new WaitForSeconds(0.02f); break;
                        case "zh": yield return new WaitForSeconds(0.03f); break;
                        default: yield return new WaitForSeconds(0.02f); break;
                    }
                }
            }
        }
        TalkQuickEnd = false;
        Talking = false;
        WaitForClick = true;
    }
    private IEnumerator ToggleCanvas(bool isVisible)
    {
        float sec = 0.2f;
        RectTransform rectTransform = textCanvas.GetComponent<RectTransform>();
        Vector2 start = rectTransform.anchoredPosition;
        Vector2 end = new Vector3(-20000f, isVisible ? -281f : -381f, 0f);
        int CurveType = isVisible ? 2 : 1;
        SpriteRenderer[] cachedSpriteRenderers = textCanvas.transform.GetComponentsInChildren<SpriteRenderer>();
        float starta = cachedSpriteRenderers.Length > 0 ? cachedSpriteRenderers[0].color.a : 0f;
        CanvasGroup[] cachedCanvasGroups = textCanvas.transform.GetComponentsInChildren<CanvasGroup>();
        yield return null;
        float timeElapsed = 0f;
        while (timeElapsed < sec)
        {
            timeElapsed += Time.deltaTime;
            float x_axis = Mathf.Lerp(start[0], end[0], Ease(timeElapsed / sec, CurveType));
            float y_axis = Mathf.Lerp(start[1], end[1], Ease(timeElapsed / sec, CurveType));
            rectTransform.anchoredPosition = new Vector3(x_axis, y_axis, 0f);
            float a = Mathf.Lerp(starta, isVisible ? 1 : 0, Ease(timeElapsed / sec, CurveType));
            foreach (SpriteRenderer spriteRenderer in cachedSpriteRenderers)
            {
                spriteRenderer.color = new Color(1f, 1f, 1f, a);
            }
            foreach (CanvasGroup canvasGroup in cachedCanvasGroups)
            {
                if (canvasGroup == null) { continue; }
                canvasGroup.alpha = a;
            }
            talkerRenderer.color = new Color(1f, 1f, 1f, hasCharaName ? a : 0f);
            autoLabelRenderer.color = new Color(1f, 1f, 1f, a);
            autoIconRenderer.color = new Color(250f / 255f, 250f / 255f, 235f / 255f, a);
            AUTORenderer.color = new Color(250f / 255f, 250f / 255f, 235f / 255f, a);
            yield return null;
        }
        foreach (SpriteRenderer spriteRenderer in cachedSpriteRenderers)
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, isVisible ? 1 : 0);
        }
        foreach (CanvasGroup canvasGroup in cachedCanvasGroups)
        {
            if (canvasGroup == null) { continue; }
            canvasGroup.alpha = isVisible ? 1 : 0;
        }
        talkerRenderer.color = new Color(1f, 1f, 1f, hasCharaName ? (isVisible ? 1 : 0) : 0f);
        autoLabelRenderer.color = new Color(1f, 1f, 1f, isVisible ? 1 : 0);
        autoIconRenderer.color = new Color(250f / 255f, 250f / 255f, 235f / 255f, isVisible ? 1 : 0);
        AUTORenderer.color = new Color(250f / 255f, 250f / 255f, 235f / 255f, isVisible ? 1 : 0);
        rectTransform.anchoredPosition = end;
    }
    private IEnumerator CharaMoting(string ADVCharaID, string MotID)
    {
        CharaMotioning.Add(ADVCharaID);
        GameObject chara = FindCached(ADVCharaID);
        advmotionlist_Params param = advMotionList.m_Params.First(param => param.m_MotionID == MotID);
        float timeElapsed;
        List<advmoParams_Datas> datas = param.m_Datas;
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        float finalx = charaProperties.MotOffset[0];
        float finaly = charaProperties.MotOffset[1];
        float finalscale = 1;
        for (int i = 0; i < datas.Count; i++)
        {
            timeElapsed = 0f;
            if (datas[i].m_Action == 1)
            {
                Vector2 start = charaProperties.MotOffset;
                float endx = datas[i].m_X;
                float endy = datas[i].m_Y;
                finalx = endx;
                finaly = endy;
                while (timeElapsed < datas[i].m_Duration)
                {
                    timeElapsed += Time.deltaTime;
                    float x_axis = Mathf.Lerp(start[0], endx, Ease(timeElapsed / datas[i].m_Duration, datas[i].m_EaseType));
                    float y_axis = Mathf.Lerp(start[1], endy, Ease(timeElapsed / datas[i].m_Duration, datas[i].m_EaseType));
                    charaProperties.MotOffset = new Vector2(x_axis, y_axis);
                    isUpdateCharaPosition.Add(ADVCharaID);
                    yield return null;
                }
            }
            else if (datas[i].m_Action == 2)
            {
                float start = charaProperties.Scale;
                float endx = datas[i].m_X;
                finalscale = endx;
                while (timeElapsed < datas[i].m_Duration)
                {
                    timeElapsed += Time.deltaTime;
                    float x_axis = Mathf.Lerp(start, endx, Ease(timeElapsed / datas[i].m_Duration, datas[i].m_EaseType));
                    charaProperties.Scale = x_axis;
                    isUpdateCharaPosition.Add(ADVCharaID);
                    yield return null;
                }
            }
            else
            {
                while (timeElapsed < datas[i].m_Duration)
                {
                    timeElapsed += Time.deltaTime;
                    yield return null;
                }
            }
        }
        charaProperties.MotOffset = new Vector2(finalx, finaly);
        charaProperties.Scale = finalscale;
        isUpdateCharaPosition.Add(ADVCharaID);
        CharaMotioning.RemoveAll(item => item == ADVCharaID);
    }
    private IEnumerator BGScaleChange(uint ID, float Scale, float Sec, int CurveType)
    {
        GameObject bg = FindCached("bg_" + ID.ToString());
        BGScaling.Add(ID);
        BGProperties bgProperties = bg.GetComponent<BGProperties>();
        float startScale = bgProperties.Scale;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            if (bg == null) { BGScaling.RemoveAll(item => item == ID); yield break; }
            timeElapsed += Time.deltaTime;
            float scale = Mathf.Lerp(startScale, Scale, Ease(timeElapsed / Sec, CurveType));
            bgProperties.Scale = scale;
            isUpdateBGScale = true;
            yield return null;
        }
        BGScaling.RemoveAll(item => item == ID);
        bgProperties.Scale = Scale;
        isUpdateBGScale = true;
    }
    private IEnumerator BGScrollChange(uint ID, float Sec, float X, float Y, int CurveType)
    {
        GameObject bg = FindCached("bg_" + ID.ToString());
        BGScrolling.Add(ID);
        BGProperties bgProperties = bg.GetComponent<BGProperties>();
        Vector2 startPos = bgProperties.Position;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            if (bg == null) { BGScrolling.RemoveAll(item => item == ID); yield break; }
            timeElapsed += Time.deltaTime;
            float x_axis = Mathf.Lerp(startPos[0], X, Ease(timeElapsed / Sec, CurveType));
            float y_axis = Mathf.Lerp(startPos[1], Y, Ease(timeElapsed / Sec, CurveType));
            bgProperties.Position = new Vector2(x_axis, y_axis);
            isUpdateBGPosition = true;
            yield return null;
        }
        BGScrolling.RemoveAll(item => item == ID);
        bgProperties.Position = new Vector2(X, Y);
        isUpdateBGPosition = true;
    }
    private IEnumerator BGColorChange(GameObject bg, Color startColor, Color endColor, float Sec, int CurveType)
    {
        SpriteRenderer spriteRenderer = bg.GetComponent<SpriteRenderer>();
        yield return null;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            if (bg == null) { yield break; }
            timeElapsed += Time.deltaTime;
            float R = Mathf.Lerp(startColor[0], endColor[0], Ease(timeElapsed / Sec, CurveType));
            float G = Mathf.Lerp(startColor[1], endColor[1], Ease(timeElapsed / Sec, CurveType));
            float B = Mathf.Lerp(startColor[2], endColor[2], Ease(timeElapsed / Sec, CurveType));
            float A = Mathf.Lerp(startColor[3], endColor[3], Ease(timeElapsed / Sec, CurveType));
            spriteRenderer.color = new Color(R, G, B, A);
            yield return null;
        }
        if (bg == null) { yield break; }
        spriteRenderer.color = endColor;
    }
    private IEnumerator SpriteScaleChange(uint ID, float X, float Y, float Sec)
    {
        SpriteScaling.Add(ID);
        yield return null;
        GameObject sprite = FindCached("Sprite_" + ID.ToString());
        RectTransform rectTransform = sprite.GetComponent<RectTransform>();
        Vector2 start = rectTransform.localScale;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            if (sprite == null) { SpriteScaling.RemoveAll(item => item == ID); yield break; }
            timeElapsed += Time.deltaTime;
            float x = Mathf.Lerp(start[0], X, timeElapsed / Sec);
            float y = Mathf.Lerp(start[1], Y, timeElapsed / Sec);
            rectTransform.localScale = new Vector3(x, y, 1f);
            yield return null;
        }
        if (sprite == null) { SpriteScaling.RemoveAll(item => item == ID); yield break; }
        rectTransform.localScale = new Vector3(X, Y, 1f);
        SpriteScaling.RemoveAll(item => item == ID);
    }
    private IEnumerator SpritePosChange(uint ID, float X, float Y, float Sec)
    {
        SpritePosing.Add(ID);
        yield return null;
        GameObject sprite = FindCached("Sprite_" + ID.ToString());
        RectTransform rectTransform = sprite.GetComponent<RectTransform>();
        Vector2 start = rectTransform.anchoredPosition;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            if (sprite == null) { SpritePosing.RemoveAll(item => item == ID); yield break; }
            timeElapsed += Time.deltaTime;
            float x = Mathf.Lerp(start[0], X, timeElapsed / Sec);
            float y = Mathf.Lerp(start[1], Y, timeElapsed / Sec);
            rectTransform.anchoredPosition = new Vector3(x, y, 0f);
            yield return null;
        }
        if (sprite == null) { SpritePosing.RemoveAll(item => item == ID); yield break; }
        rectTransform.anchoredPosition = new Vector3(X, Y, 1f);
        SpritePosing.RemoveAll(item => item == ID);
    }
    private IEnumerator SpriteFade(uint ID, float Sec, float A)
    {
        SpriteFading.Add(ID);
        yield return null;
        GameObject sprite = FindCached("Sprite_" + ID.ToString());
        SpriteRenderer spriteRenderer = sprite.GetComponent<SpriteRenderer>();
        SpriteProperties spriteProperties = sprite.GetComponent<SpriteProperties>();
        Color color = spriteProperties.color;
        float start = spriteProperties.fade;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            if (sprite == null) { SpriteFading.RemoveAll(item => item == ID); yield break; }
            timeElapsed += Time.deltaTime;
            float a = Mathf.Lerp(start, A, timeElapsed / Sec);
            spriteProperties.fade = a;
            spriteRenderer.color = new Color(color.r, color.g, color.b, color.a * spriteProperties.fade);
            yield return null;
        }
        if (sprite == null) { SpriteFading.RemoveAll(item => item == ID); yield break; }
        spriteProperties.fade = A;
        spriteRenderer.color = new Color(color.r, color.g, color.b, color.a * spriteProperties.fade);
        SpriteFading.RemoveAll(item => item == ID);
    }
    private IEnumerator SpriteColorChange(uint ID, Color color, float Sec)
    {
        SpriteColoring.Add(ID);
        yield return null;
        GameObject sprite = FindCached("Sprite_" + ID.ToString());
        SpriteRenderer spriteRenderer = sprite.GetComponent<SpriteRenderer>();
        Color start = spriteRenderer.color;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            if (sprite == null) { SpriteColoring.RemoveAll(item => item == ID); yield break; }
            timeElapsed += Time.deltaTime;
            float r = Mathf.Lerp(start.r, color.r, timeElapsed / Sec);
            float g = Mathf.Lerp(start.g, color.g, timeElapsed / Sec);
            float b = Mathf.Lerp(start.b, color.b, timeElapsed / Sec);
            float a = Mathf.Lerp(start.a, color.a, timeElapsed / Sec);
            spriteRenderer.color = new Color(r, g, b, a);
            yield return null;
        }
        if (sprite == null) { SpriteColoring.RemoveAll(item => item == ID); yield break; }
        spriteRenderer.color = color;
        SpriteColoring.RemoveAll(item => item == ID);
    }
    private IEnumerator Caption(uint textID)
    {
        WaitForClickCaption = true;
        PlayingCaption = true;
        CaptionTextScript = advScriptText.m_Params.First(param => param.m_ID == textID).m_text;
        yield return null;
        Coroutine BGStartcoroutine = StartCoroutine(CaptionStartBG());
        Coroutine TextStartcoroutine = StartCoroutine(CaptionStartText());
        autoSkipCoroutine.Add(StartCoroutine(AutoSkip(2f)));
        while (WaitForClickCaption)
        {
            yield return null;
        }
        foreach (Coroutine coroutine in new Coroutine[2] { BGStartcoroutine, TextStartcoroutine })
        {
            yield return coroutine;
        }
        Coroutine BGEndcoroutine = StartCoroutine(CaptionEndBG());
        Coroutine TextEndcoroutine = StartCoroutine(CaptionEndText());
        foreach (Coroutine coroutine in new Coroutine[2] { BGEndcoroutine, TextEndcoroutine })
        {
            yield return coroutine;
        }
        PlayingCaption = false;
    }
    private IEnumerator CaptionStartBG()
    {
        GameObject bg = new GameObject("CaptionBG");
        bg.transform.SetParent(canvas.transform);
        RectTransform bgTransform = bg.AddComponent<RectTransform>();
        SpriteRenderer bgRenderer = bg.AddComponent<SpriteRenderer>();
        Texture2D CaptionBG = new Texture2D(0, 0);
        CaptionBG.LoadImage(CaptionBGSprite);
        CaptionBG.wrapMode = TextureWrapMode.Clamp;
        Sprite sprite = Sprite.Create(CaptionBG, new Rect(0, 0, CaptionBG.width, CaptionBG.height), new Vector2(0.5f, 0.5f), 1);
        bgRenderer.sprite = sprite;
        bgRenderer.sortingOrder = -3;
        ColorUtility.TryParseHtmlString(CaptionRGBA["BG"][0], out Color bgColorStart);
        ColorUtility.TryParseHtmlString(CaptionRGBA["BG"][1], out Color bgColorIdle);
        Vector2 WHscale = new Vector2(CaptionBGSpriteWH[0] / CaptionBG.width, CaptionBGSpriteWH[1] / CaptionBG.height);
        bgTransform.anchoredPosition = new Vector2(CaptionPosScl["BG"][0, 0], CaptionPosScl["BG"][0, 1]);
        bgTransform.localScale = new Vector3(CaptionPosScl["BG"][0, 2] * WHscale[0], CaptionPosScl["BG"][0, 3] * WHscale[1], 1f);
        bgRenderer.color = bgColorStart;
        float timeElapsed = 0f;
        while (timeElapsed < CaptionSecDelay["BG"][0, 1])
        {
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        timeElapsed = 0f;
        while (timeElapsed < CaptionSecDelay["BG"][0, 0])
        {
            timeElapsed += Time.deltaTime;
            float EaseTime = Ease(timeElapsed / CaptionSecDelay["BG"][0, 0], CaptionCurveType["BG"][0]);
            float posX = Mathf.Lerp(CaptionPosScl["BG"][0, 0], CaptionPosScl["BG"][1, 0], EaseTime);
            float posY = Mathf.Lerp(CaptionPosScl["BG"][0, 1], CaptionPosScl["BG"][1, 1], EaseTime);
            float sclX = Mathf.Lerp(CaptionPosScl["BG"][0, 2], CaptionPosScl["BG"][1, 2], EaseTime);
            float sclY = Mathf.Lerp(CaptionPosScl["BG"][0, 3], CaptionPosScl["BG"][1, 3], EaseTime);
            float R = Mathf.Lerp(bgColorStart.r, bgColorIdle.r, EaseTime);
            float G = Mathf.Lerp(bgColorStart.g, bgColorIdle.g, EaseTime);
            float B = Mathf.Lerp(bgColorStart.b, bgColorIdle.b, EaseTime);
            float A = Mathf.Lerp(bgColorStart.a, bgColorIdle.a, EaseTime);
            bgTransform.anchoredPosition = new Vector2(posX, posY);
            bgTransform.localScale = new Vector3(sclX * WHscale[0], sclY * WHscale[1], 1f);
            bgRenderer.color = new Color(R, G, B, A);
            yield return null;
        }
        bgTransform.anchoredPosition = new Vector2(CaptionPosScl["BG"][1, 0], CaptionPosScl["BG"][1, 1]);
        bgTransform.localScale = new Vector3(CaptionPosScl["BG"][1, 2] * WHscale[0], CaptionPosScl["BG"][1, 3] * WHscale[1], 1f);
        bgRenderer.color = bgColorIdle;
        bg.layer = LayerMask.NameToLayer("Caption");
    }
    private IEnumerator CaptionStartText()
    {
        GameObject text = new GameObject("CaptionText");
        text.transform.SetParent(canvas.transform);
        RectTransform textTransform = text.AddComponent<RectTransform>();
        Text textText = text.AddComponent<Text>();
        textText.text = CaptionTextScript;
        ColorUtility.TryParseHtmlString(CaptionRGBA["Text"][0], out Color textColorStart);
        ColorUtility.TryParseHtmlString(CaptionRGBA["Text"][1], out Color textColorIdle);
        Vector2 WHscale = new Vector2(1f, 1f);
        textTransform.anchoredPosition = new Vector2(CaptionPosScl["Text"][0, 0], CaptionPosScl["Text"][0, 1]);
        textTransform.localScale = new Vector3(CaptionPosScl["Text"][0, 2] * WHscale[0], CaptionPosScl["Text"][0, 3] * WHscale[1], 1f);
        textTransform.sizeDelta = new Vector2(1334f, 750f);
        textText.color = textColorStart;
        textText.font = font;
        textText.fontSize = 36;
        textText.lineSpacing = 1f;
        textText.alignment = TextAnchor.MiddleCenter;
        float timeElapsed = 0f;
        while (timeElapsed < CaptionSecDelay["Text"][0, 1])
        {
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        timeElapsed = 0f;
        while (timeElapsed < CaptionSecDelay["Text"][0, 0])
        {
            timeElapsed += Time.deltaTime;
            float EaseTime = Ease(timeElapsed / CaptionSecDelay["Text"][0, 0], CaptionCurveType["Text"][0]);
            float posX = Mathf.Lerp(CaptionPosScl["Text"][0, 0], CaptionPosScl["Text"][1, 0], EaseTime);
            float posY = Mathf.Lerp(CaptionPosScl["Text"][0, 1], CaptionPosScl["Text"][1, 1], EaseTime);
            float sclX = Mathf.Lerp(CaptionPosScl["Text"][0, 2], CaptionPosScl["Text"][1, 2], EaseTime);
            float sclY = Mathf.Lerp(CaptionPosScl["Text"][0, 3], CaptionPosScl["Text"][1, 3], EaseTime);
            float R = Mathf.Lerp(textColorStart.r, textColorIdle.r, EaseTime);
            float G = Mathf.Lerp(textColorStart.g, textColorIdle.g, EaseTime);
            float B = Mathf.Lerp(textColorStart.b, textColorIdle.b, EaseTime);
            float A = Mathf.Lerp(textColorStart.a, textColorIdle.a, EaseTime);
            textTransform.anchoredPosition = new Vector2(posX, posY);
            textTransform.localScale = new Vector3(sclX * WHscale[0], sclY * WHscale[1], 1f);
            textText.color = new Color(R, G, B, A);
            yield return null;
        }
        textTransform.anchoredPosition = new Vector2(CaptionPosScl["Text"][1, 0], CaptionPosScl["Text"][1, 1]);
        textTransform.localScale = new Vector3(CaptionPosScl["Text"][1, 2] * WHscale[0], CaptionPosScl["Text"][1, 3] * WHscale[1], 1f);
        textText.color = textColorIdle;
        text.layer = LayerMask.NameToLayer("Caption");
    }
    private IEnumerator CaptionEndBG()
    {
        GameObject bg = FindCached("CaptionBG");
        RectTransform bgTransform = bg.GetComponent<RectTransform>();
        SpriteRenderer bgRenderer = bg.GetComponent<SpriteRenderer>();
        ColorUtility.TryParseHtmlString(CaptionRGBA["BG"][1], out Color bgColorIdle);
        ColorUtility.TryParseHtmlString(CaptionRGBA["BG"][2], out Color bgColorEnd);
        Texture2D CaptionBG = new Texture2D(0, 0);
        CaptionBG.LoadImage(CaptionBGSprite);
        Vector2 WHscale = new Vector2(CaptionBGSpriteWH[0] / CaptionBG.width, CaptionBGSpriteWH[1] / CaptionBG.height);
        bgTransform.anchoredPosition = new Vector2(CaptionPosScl["BG"][1, 0], CaptionPosScl["BG"][1, 1]);
        bgTransform.localScale = new Vector3(CaptionPosScl["BG"][1, 2] * WHscale[0], CaptionPosScl["BG"][1, 3] * WHscale[1], 1f);
        bgRenderer.color = bgColorIdle;
        float timeElapsed = 0f;
        while (timeElapsed < CaptionSecDelay["BG"][1, 1])
        {
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        timeElapsed = 0f;
        while (timeElapsed < CaptionSecDelay["BG"][1, 0])
        {
            timeElapsed += Time.deltaTime;
            float EaseTime = Ease(timeElapsed / CaptionSecDelay["BG"][1, 0], CaptionCurveType["BG"][1]);
            float posX = Mathf.Lerp(CaptionPosScl["BG"][1, 0], CaptionPosScl["BG"][2, 0], EaseTime);
            float posY = Mathf.Lerp(CaptionPosScl["BG"][1, 1], CaptionPosScl["BG"][2, 1], EaseTime);
            float sclX = Mathf.Lerp(CaptionPosScl["BG"][1, 2], CaptionPosScl["BG"][2, 2], EaseTime);
            float sclY = Mathf.Lerp(CaptionPosScl["BG"][1, 3], CaptionPosScl["BG"][2, 3], EaseTime);
            float R = Mathf.Lerp(bgColorIdle.r, bgColorEnd.r, EaseTime);
            float G = Mathf.Lerp(bgColorIdle.g, bgColorEnd.g, EaseTime);
            float B = Mathf.Lerp(bgColorIdle.b, bgColorEnd.b, EaseTime);
            float A = Mathf.Lerp(bgColorIdle.a, bgColorEnd.a, EaseTime);
            bgTransform.anchoredPosition = new Vector2(posX, posY);
            bgTransform.localScale = new Vector3(sclX * WHscale[0], sclY * WHscale[1], 1f);
            bgRenderer.color = new Color(R, G, B, A);
            yield return null;
        }
        bgTransform.anchoredPosition = new Vector2(CaptionPosScl["BG"][2, 0], CaptionPosScl["BG"][2, 1]);
        bgTransform.localScale = new Vector3(CaptionPosScl["BG"][2, 2] * WHscale[0], CaptionPosScl["BG"][2, 3] * WHscale[1], 1f);
        bgRenderer.color = bgColorEnd;
        Destroy(bg);
    }
    private IEnumerator CaptionEndText()
    {
        GameObject text = FindCached("CaptionText");
        RectTransform textTransform = text.GetComponent<RectTransform>();
        Text textText = text.GetComponent<Text>();
        ColorUtility.TryParseHtmlString(CaptionRGBA["Text"][1], out Color textColorIdle);
        ColorUtility.TryParseHtmlString(CaptionRGBA["Text"][2], out Color textColorEnd);
        Vector2 WHscale = new Vector2(1f, 1f);
        textTransform.anchoredPosition = new Vector2(CaptionPosScl["Text"][1, 0], CaptionPosScl["Text"][1, 1]);
        textTransform.localScale = new Vector3(CaptionPosScl["Text"][1, 2] * WHscale[0], CaptionPosScl["Text"][1, 3] * WHscale[1], 1f);
        textText.color = textColorIdle;
        float timeElapsed = 0f;
        while (timeElapsed < CaptionSecDelay["Text"][1, 1])
        {
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        timeElapsed = 0f;
        while (timeElapsed < CaptionSecDelay["Text"][1, 0])
        {
            timeElapsed += Time.deltaTime;
            float EaseTime = Ease(timeElapsed / CaptionSecDelay["Text"][1, 0], CaptionCurveType["Text"][1]);
            float posX = Mathf.Lerp(CaptionPosScl["Text"][1, 0], CaptionPosScl["Text"][2, 0], EaseTime);
            float posY = Mathf.Lerp(CaptionPosScl["Text"][1, 1], CaptionPosScl["Text"][2, 1], EaseTime);
            float sclX = Mathf.Lerp(CaptionPosScl["Text"][1, 2], CaptionPosScl["Text"][2, 2], EaseTime);
            float sclY = Mathf.Lerp(CaptionPosScl["Text"][1, 3], CaptionPosScl["Text"][2, 3], EaseTime);
            float R = Mathf.Lerp(textColorIdle.r, textColorEnd.r, EaseTime);
            float G = Mathf.Lerp(textColorIdle.g, textColorEnd.g, EaseTime);
            float B = Mathf.Lerp(textColorIdle.b, textColorEnd.b, EaseTime);
            float A = Mathf.Lerp(textColorIdle.a, textColorEnd.a, EaseTime);
            textTransform.anchoredPosition = new Vector2(posX, posY);
            textTransform.localScale = new Vector3(sclX * WHscale[0], sclY * WHscale[1], 1f);
            textText.color = new Color(R, G, B, A);
            yield return null;
        }
        textTransform.anchoredPosition = new Vector2(CaptionPosScl["Text"][2, 0], CaptionPosScl["Text"][2, 1]);
        textTransform.localScale = new Vector3(CaptionPosScl["Text"][2, 2] * WHscale[0], CaptionPosScl["Text"][2, 3] * WHscale[1], 1f);
        textText.color = textColorEnd;
        Destroy(text);
    }
    private IEnumerator PlayEffect(GameObject ef, GameObject asset, string EffectID, float X, float Y, float Rotate, bool isCharaBehind, bool isLoop, float multiple, int sortingOrder, bool isMuted)
    {
        RectTransform rectTransform = ef.GetComponent<RectTransform>();
        ef.layer = isCharaBehind ? LayerMask.NameToLayer("Effect_CharaBehind") : LayerMask.NameToLayer("Effect");
        ef.transform.SetParent(effectCanvas.transform);
        efjsonanimclip efJsonAnimClip = null;
        if (webText.ContainsKey(EffectID + @"\" + EffectID + "@Take 001.json"))
        {
            efJsonAnimClip = webAnimClip[EffectID + @"\" + EffectID + "@Take 001.json"];
        }
        MsbHandlerJson msbHandler = webMsbHandler[EffectID + @"\MsbHandler.json"];
        MeigeAnimClipHolderJson meigeAnimClipHolderJson = webMeigeAnimClipHolder[EffectID + @"\MeigeAnimClipHolder.json"];
        GameObject efClone = asset.GetComponentsInChildren<Transform>()[2].gameObject;
        Dictionary<GameObject, GameObject> f = new Dictionary<GameObject, GameObject> { { efClone, ef } };
        Dictionary<GameObject, RuleJson> fPtcl = new Dictionary<GameObject, RuleJson>();
        Dictionary<GameObject, Material> fPtclMat = new Dictionary<GameObject, Material>();
        Dictionary<GameObject, GameObject> fPtclRoot = new Dictionary<GameObject, GameObject>();
        List<GameObject> efObjects = new List<GameObject> { ef };
        List<string> efMaterials = new List<string>();
        List<GameObject> efPtclParents = new List<GameObject>();
        ef.transform.localPosition = new Vector3(efClone.transform.localPosition.x, efClone.transform.localPosition.y, efClone.transform.localPosition.z);
        ef.transform.localRotation = efClone.transform.localRotation;
        ef.transform.localScale = efClone.transform.localScale;
        if (efClone.GetComponent<MeshRenderer>() != null)
        {
            MsbObjectHandler msbParams = msbHandler.m_MsbObjectHandlerArray.FirstOrDefault(param => param.m_Name == ef.name);
            MeshFilter meshFilter = ef.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = ef.AddComponent<MeshRenderer>();
            meshFilter.mesh = efClone.GetComponent<MeshFilter>().sharedMesh;
            MsbMaterialHandler efMaterialHandler = msbHandler.m_MsbMaterialHandlerArray.First(param => param.m_Name == efClone.GetComponent<MeshRenderer>().sharedMaterial.name);
            Material material = new Material(Shader.Find("CustomShader_EF"));
            switch (efMaterialHandler.m_Src.m_BlendMode)
            {
                case 1:
                    material.SetInt(_BlendDst, 10);
                    break;
                case 2:
                    material.SetInt(_BlendDst, 1);
                    break;
            }
            material.name = efClone.GetComponent<MeshRenderer>().sharedMaterial.name;
            if (!efMaterials.Contains(material.name))
            {
                efMaterials.Add(material.name);
            }
            meshRenderer.sharedMaterial = material;
            if (msbParams != null)
            {
                material.SetFloat(_HDRFactor, msbParams.m_Src.m_HDRFactor);
                material.SetVector(_MeshColor, new Vector4(msbParams.m_Src.m_MeshColor.r, msbParams.m_Src.m_MeshColor.g, msbParams.m_Src.m_MeshColor.b, msbParams.m_Src.m_MeshColor.a));
            }
        }
        for (int i = 1; i < efClone.GetComponentsInChildren<Transform>().Count(); i++)
        {
            Transform transform = efClone.GetComponentsInChildren<Transform>()[i];
            GameObject efCloneObject = transform.gameObject;
            if (efCloneObject.GetComponent<MeshRenderer>() == null)
            {
                if (efCloneObject.name.StartsWith("ptcl"))
                {
                    continue;
                }
                GameObject efObject = new GameObject(efCloneObject.name);
                f.Add(efCloneObject, efObject);
                efObjects.Add(efObject);
                efObject.transform.SetParent(f[efCloneObject.transform.parent.gameObject].transform);
                efObject.transform.localPosition = efCloneObject.transform.localPosition;
                efObject.transform.localRotation = efCloneObject.transform.localRotation;
                efObject.transform.localScale = efCloneObject.transform.localScale;
                efObject.layer = isCharaBehind ? LayerMask.NameToLayer("Effect_CharaBehind") : LayerMask.NameToLayer("Effect");
            }
            else if (msbHandler.m_MsbObjectHandlerArray.FirstOrDefault(param => param.m_Name == efCloneObject.name) != null)
            {
                GameObject efObject = new GameObject(efCloneObject.name);
                MsbObjectHandler msbParams = msbHandler.m_MsbObjectHandlerArray.First(param => param.m_Name == efObject.name);
                f.Add(efCloneObject, efObject);
                efObjects.Add(efObject);
                efObject.SetActive(false);
                efObject.transform.SetParent(f[efCloneObject.transform.parent.gameObject].transform);
                MeshFilter meshFilter = efObject.AddComponent<MeshFilter>();
                MeshRenderer meshRenderer = efObject.AddComponent<MeshRenderer>();
                meshFilter.mesh = efCloneObject.GetComponent<MeshFilter>().sharedMesh;
                MsbMaterialHandler efMaterialHandler = null;
                if ("Lit" == efCloneObject.GetComponent<MeshRenderer>().sharedMaterial.name)
                {
                    efMaterialHandler = msbHandler.m_MsbMaterialHandlerArray.First(param => param.m_Name == "m_ef_ADV_seal_flashline");
                }
                else
                {
                    efMaterialHandler = msbHandler.m_MsbMaterialHandlerArray.First(param => param.m_Name == efCloneObject.GetComponent<MeshRenderer>().sharedMaterial.name);
                }
                Material material = new Material(Shader.Find("CustomShader_EF"));
                switch (efMaterialHandler.m_Src.m_BlendMode)
                {
                    case 1:
                        material.SetInt(_BlendDst, 10);
                        break;
                    case 2:
                        material.SetInt(_BlendDst, 1);
                        break;
                }
                material.name = efCloneObject.GetComponent<MeshRenderer>().sharedMaterial.name;
                if ("Lit" == efCloneObject.GetComponent<MeshRenderer>().sharedMaterial.name)
                {
                    material.name = "m_ef_ADV_seal_flashline";
                }
                if (!efMaterials.Contains(material.name))
                {
                    efMaterials.Add(material.name);
                }
                meshRenderer.sharedMaterial = material;
                material.SetFloat(_HDRFactor, msbParams.m_Src.m_HDRFactor);
                material.SetVector(_MeshColor, new Vector4(msbParams.m_Src.m_MeshColor.r, msbParams.m_Src.m_MeshColor.g, msbParams.m_Src.m_MeshColor.b, msbParams.m_Src.m_MeshColor.a));
                efObject.transform.localPosition = efCloneObject.transform.localPosition;
                efObject.transform.localRotation = efCloneObject.transform.localRotation;
                efObject.transform.localScale = efCloneObject.transform.localScale;
                efObject.layer = isCharaBehind ? LayerMask.NameToLayer("Effect_CharaBehind") : LayerMask.NameToLayer("Effect");
            }
            else
            {
                GameObject ptclParent = new GameObject(efCloneObject.name);
                GameObject efObject = new GameObject("ptcl:" + efCloneObject.name);
                GameObject efRoot = new GameObject("ptcl:" + efCloneObject.name);
                efRoot.transform.SetParent(particleObj.transform);
                efObject.transform.SetParent(ptclParent.transform);
                f.Add(efCloneObject, ptclParent);
                fPtclRoot.Add(efObject, efRoot);
                efObjects.Add(ptclParent);
                ptclParent.transform.SetParent(f[efCloneObject.transform.parent.gameObject].transform);
                efPtclParents.Add(ptclParent);
                MeigeParticleEmitterJson meigeParticleEmitterJson = webMeigeParticleEmitter[EffectID + @"\MeigeParticleEmitter/" + ptclParent.name + ".json"];
                RuleJson rule = meigeParticleEmitterJson.m_Rule;
                MeshFilter meshFilter = ptclParent.AddComponent<MeshFilter>();
                MeshRenderer meshRenderer = ptclParent.AddComponent<MeshRenderer>();
                meshRenderer.enabled = false;
                meshFilter.mesh = efCloneObject.GetComponent<MeshFilter>().sharedMesh;
                Material material = new Material(Shader.Find("CustomShader_COMMON"));
                MsbMaterialHandler efMaterialHandler = msbHandler.m_MsbMaterialHandlerArray.First(param => param.m_Name == efCloneObject.GetComponent<MeshRenderer>().sharedMaterial.name);
                switch (efMaterialHandler.m_Src.m_BlendMode)
                {
                    case 1:
                        material.SetInt(_BlendDst, 10);
                        break;
                    case 2:
                        material.SetInt(_BlendDst, 1);
                        break;
                }
                material.name = efCloneObject.GetComponent<MeshRenderer>().sharedMaterial.name;
                if (!efMaterials.Contains(material.name))
                {
                    efMaterials.Add(material.name);
                }
                meshRenderer.sharedMaterial = material;
                ptclParent.transform.localPosition = efCloneObject.transform.localPosition;
                ptclParent.transform.localRotation = efCloneObject.transform.localRotation;
                ptclParent.transform.localScale = efCloneObject.transform.localScale;
                efObject.transform.localPosition = new Vector3(0f, 0f, 0f);
                efObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                efObject.transform.localScale = new Vector3(1f, 1f, 1f) * multiple;
                efObject.layer = isCharaBehind ? LayerMask.NameToLayer("Effect_CharaBehind") : LayerMask.NameToLayer("Effect");
                efRoot.transform.position = new Vector3(0f, 0f, 0f);
                efRoot.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                efRoot.transform.localScale = new Vector3(1f, 1f, 1f);
                efRoot.layer = isCharaBehind ? LayerMask.NameToLayer("Effect_CharaBehind") : LayerMask.NameToLayer("Effect");
                ParticleObjectParams particleObjectParams = efObject.AddComponent<ParticleObjectParams>();
                particleObjectParams.m_thisTransform = ptclParent.transform;
                material.SetTexture(_MainTex, webTexture[EffectID + @"\" + efMaterialHandler.m_Src.m_Texture[0].m_Name + ".png"]);
                if (efMaterialHandler.m_Src.m_Texture.Count == 2)
                {
                    material.SetTexture(_AlphaTex, webTexture[EffectID + @"\" + efMaterialHandler.m_Src.m_Texture[1].m_Name + ".png"]);
                }
                fPtcl.Add(efObject, rule);
                fPtclMat.Add(efObject, material);
            }
        }
        float sampleRate = meigeAnimClipHolderJson.m_MeigeAnimClip.m_BaseFPS;
        float animtime = meigeAnimClipHolderJson.m_MeigeAnimClip.m_AnimTimeBySec;
        Dictionary<string, Dictionary<string, AnimationCurve>> animCurves = new Dictionary<string, Dictionary<string, AnimationCurve>>();
        foreach (GameObject efObject in efObjects)
        {
            animCurves[efObject.name] = new Dictionary<string, AnimationCurve>{
                {"positionx",new AnimationCurve()},
                {"positiony",new AnimationCurve()},
                {"positionz",new AnimationCurve()},
                {"rotationx",new AnimationCurve()},
                {"rotationy",new AnimationCurve()},
                {"rotationz",new AnimationCurve()},
                {"rotationw",new AnimationCurve()},
                {"scalex",new AnimationCurve()},
                {"scaley",new AnimationCurve()},
                {"scalez",new AnimationCurve()},
                {"enabled",new AnimationCurve()},
                {"meshcolorr",new AnimationCurve()},
                {"meshcolorg",new AnimationCurve()},
                {"meshcolorb",new AnimationCurve()},
                {"meshcolora",new AnimationCurve()}
            };
        }
        foreach (string efMaterial in efMaterials)
        {
            animCurves[efMaterial] = new Dictionary<string, AnimationCurve>{
                {"tilingx",new AnimationCurve()},
                {"tilingy",new AnimationCurve()},
                {"offsetx",new AnimationCurve()},
                {"offsety",new AnimationCurve()},
                {"matcolorr",new AnimationCurve()},
                {"matcolorg",new AnimationCurve()},
                {"matcolorb",new AnimationCurve()},
                {"matcolora",new AnimationCurve()},
                {"rotation",new AnimationCurve()},
                {"tilingx1",new AnimationCurve()},
                {"tilingy1",new AnimationCurve()},
                {"offsetx1",new AnimationCurve()},
                {"offsety1",new AnimationCurve()},
                {"matcolorr1",new AnimationCurve()},
                {"matcolorg1",new AnimationCurve()},
                {"matcolorb1",new AnimationCurve()},
                {"matcolora1",new AnimationCurve()},
                {"rotation1",new AnimationCurve()},
            };
        }
        if (efJsonAnimClip != null)
        {
            foreach (PositionCurvesArray positionCurvesArray in efJsonAnimClip.Base.m_PositionCurves.Array)
            {
                string objname = positionCurvesArray.data.path.Length == 0 ? ef.name : positionCurvesArray.data.path.Contains('/') ? positionCurvesArray.data.path[(positionCurvesArray.data.path.LastIndexOf('/') + 1)..] : positionCurvesArray.data.path;
                foreach (Curve3Array keyframe in positionCurvesArray.data.curve.m_Curve.Array)
                {
                    Keyframe keyframex = new(keyframe.data.time, keyframe.data.value.x);
                    keyframex.inTangent = keyframe.data.inSlope.x;
                    keyframex.outTangent = keyframe.data.outSlope.x;
                    keyframex.inWeight = keyframe.data.inWeight.x;
                    keyframex.outWeight = keyframe.data.outWeight.x;
                    keyframex.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                    animCurves[objname]["positionx"].AddKey(keyframex);
                    Keyframe keyframey = new(keyframe.data.time, keyframe.data.value.y);
                    keyframey.inTangent = keyframe.data.inSlope.y;
                    keyframey.outTangent = keyframe.data.outSlope.y;
                    keyframey.inWeight = keyframe.data.inWeight.y;
                    keyframey.outWeight = keyframe.data.outWeight.y;
                    keyframey.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                    animCurves[objname]["positiony"].AddKey(keyframey);
                    Keyframe keyframez = new(keyframe.data.time, keyframe.data.value.z);
                    keyframez.inTangent = keyframe.data.inSlope.z;
                    keyframez.outTangent = keyframe.data.outSlope.z;
                    keyframez.inWeight = keyframe.data.inWeight.z;
                    keyframez.outWeight = keyframe.data.outWeight.z;
                    keyframez.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                    animCurves[objname]["positionz"].AddKey(keyframez);
                    if (isLoop && keyframe.data.time == 0)
                    {
                        keyframex = new(animtime + 1 / sampleRate, keyframe.data.value.x);
                        keyframex.inTangent = keyframe.data.inSlope.x;
                        keyframex.outTangent = keyframe.data.outSlope.x;
                        keyframex.inWeight = keyframe.data.inWeight.x;
                        keyframex.outWeight = keyframe.data.outWeight.x;
                        keyframex.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                        animCurves[objname]["positionx"].AddKey(keyframex);
                        keyframey = new(animtime + 1 / sampleRate, keyframe.data.value.y);
                        keyframey.inTangent = keyframe.data.inSlope.y;
                        keyframey.outTangent = keyframe.data.outSlope.y;
                        keyframey.inWeight = keyframe.data.inWeight.y;
                        keyframey.outWeight = keyframe.data.outWeight.y;
                        keyframey.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                        animCurves[objname]["positiony"].AddKey(keyframey);
                        keyframez = new(animtime + 1 / sampleRate, keyframe.data.value.z);
                        keyframez.inTangent = keyframe.data.inSlope.z;
                        keyframez.outTangent = keyframe.data.outSlope.z;
                        keyframez.inWeight = keyframe.data.inWeight.z;
                        keyframez.outWeight = keyframe.data.outWeight.z;
                        keyframez.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                        animCurves[objname]["positionz"].AddKey(keyframez);
                    }
                }
            }
            foreach (RotationCurvesArray rotationCurvesArray in efJsonAnimClip.Base.m_RotationCurves.Array)
            {
                string objname = rotationCurvesArray.data.path.Length == 0 ? ef.name : rotationCurvesArray.data.path.Contains('/') ? rotationCurvesArray.data.path[(rotationCurvesArray.data.path.LastIndexOf('/') + 1)..] : rotationCurvesArray.data.path;
                foreach (Curve4Array keyframe in rotationCurvesArray.data.curve.m_Curve.Array)
                {
                    Keyframe keyframex = new(keyframe.data.time, keyframe.data.value.x);
                    keyframex.inTangent = keyframe.data.inSlope.x;
                    keyframex.outTangent = keyframe.data.outSlope.x;
                    keyframex.inWeight = keyframe.data.inWeight.x;
                    keyframex.outWeight = keyframe.data.outWeight.x;
                    keyframex.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                    animCurves[objname]["rotationx"].AddKey(keyframex);
                    Keyframe keyframey = new(keyframe.data.time, keyframe.data.value.y);
                    keyframey.inTangent = keyframe.data.inSlope.y;
                    keyframey.outTangent = keyframe.data.outSlope.y;
                    keyframey.inWeight = keyframe.data.inWeight.y;
                    keyframey.outWeight = keyframe.data.outWeight.y;
                    keyframey.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                    animCurves[objname]["rotationy"].AddKey(keyframey);
                    Keyframe keyframez = new(keyframe.data.time, keyframe.data.value.z);
                    keyframez.inTangent = keyframe.data.inSlope.z;
                    keyframez.outTangent = keyframe.data.outSlope.z;
                    keyframez.inWeight = keyframe.data.inWeight.z;
                    keyframez.outWeight = keyframe.data.outWeight.z;
                    keyframez.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                    animCurves[objname]["rotationz"].AddKey(keyframez);
                    Keyframe keyframew = new(keyframe.data.time, keyframe.data.value.w);
                    keyframew.inTangent = keyframe.data.inSlope.w;
                    keyframew.outTangent = keyframe.data.outSlope.w;
                    keyframew.inWeight = keyframe.data.inWeight.w;
                    keyframew.outWeight = keyframe.data.outWeight.w;
                    keyframew.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                    animCurves[objname]["rotationw"].AddKey(keyframew);
                    if (isLoop && keyframe.data.time == 0)
                    {
                        keyframex = new(animtime + 1 / sampleRate, keyframe.data.value.x);
                        keyframex.inTangent = keyframe.data.inSlope.x;
                        keyframex.outTangent = keyframe.data.outSlope.x;
                        keyframex.inWeight = keyframe.data.inWeight.x;
                        keyframex.outWeight = keyframe.data.outWeight.x;
                        keyframex.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                        animCurves[objname]["rotationx"].AddKey(keyframex);
                        keyframey = new(animtime + 1 / sampleRate, keyframe.data.value.y);
                        keyframey.inTangent = keyframe.data.inSlope.y;
                        keyframey.outTangent = keyframe.data.outSlope.y;
                        keyframey.inWeight = keyframe.data.inWeight.y;
                        keyframey.outWeight = keyframe.data.outWeight.y;
                        keyframey.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                        animCurves[objname]["rotationy"].AddKey(keyframey);
                        keyframez = new(animtime + 1 / sampleRate, keyframe.data.value.z);
                        keyframez.inTangent = keyframe.data.inSlope.z;
                        keyframez.outTangent = keyframe.data.outSlope.z;
                        keyframez.inWeight = keyframe.data.inWeight.z;
                        keyframez.outWeight = keyframe.data.outWeight.z;
                        keyframez.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                        animCurves[objname]["rotationz"].AddKey(keyframez);
                        keyframew = new(keyframe.data.time, keyframe.data.value.w);
                        keyframew.inTangent = keyframe.data.inSlope.w;
                        keyframew.outTangent = keyframe.data.outSlope.w;
                        keyframew.inWeight = keyframe.data.inWeight.w;
                        keyframew.outWeight = keyframe.data.outWeight.w;
                        keyframew.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                        animCurves[objname]["rotationw"].AddKey(keyframew);
                    }
                }
            }
            foreach (ScaleCurvesArray scaleCurvesArray in efJsonAnimClip.Base.m_ScaleCurves.Array)
            {
                string objname = scaleCurvesArray.data.path.Length == 0 ? ef.name : scaleCurvesArray.data.path.Contains('/') ? scaleCurvesArray.data.path[(scaleCurvesArray.data.path.LastIndexOf('/') + 1)..] : scaleCurvesArray.data.path;
                foreach (Curve3Array keyframe in scaleCurvesArray.data.curve.m_Curve.Array)
                {
                    Keyframe keyframex = new(keyframe.data.time, keyframe.data.value.x);
                    keyframex.inTangent = keyframe.data.inSlope.x;
                    keyframex.outTangent = keyframe.data.outSlope.x;
                    keyframex.inWeight = keyframe.data.inWeight.x;
                    keyframex.outWeight = keyframe.data.outWeight.x;
                    keyframex.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                    animCurves[objname]["scalex"].AddKey(keyframex);
                    Keyframe keyframey = new(keyframe.data.time, keyframe.data.value.y);
                    keyframey.inTangent = keyframe.data.inSlope.y;
                    keyframey.outTangent = keyframe.data.outSlope.y;
                    keyframey.inWeight = keyframe.data.inWeight.y;
                    keyframey.outWeight = keyframe.data.outWeight.y;
                    keyframey.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                    animCurves[objname]["scaley"].AddKey(keyframey);
                    Keyframe keyframez = new(keyframe.data.time, keyframe.data.value.z);
                    keyframez.inTangent = keyframe.data.inSlope.z;
                    keyframez.outTangent = keyframe.data.outSlope.z;
                    keyframez.inWeight = keyframe.data.inWeight.z;
                    keyframez.outWeight = keyframe.data.outWeight.z;
                    keyframez.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                    animCurves[objname]["scalez"].AddKey(keyframez);
                    if (isLoop && keyframe.data.time == 0)
                    {
                        keyframex = new(animtime + 1 / sampleRate, keyframe.data.value.x);
                        keyframex.inTangent = keyframe.data.inSlope.x;
                        keyframex.outTangent = keyframe.data.outSlope.x;
                        keyframex.inWeight = keyframe.data.inWeight.x;
                        keyframex.outWeight = keyframe.data.outWeight.x;
                        keyframex.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                        animCurves[objname]["scalex"].AddKey(keyframex);
                        keyframey = new(animtime + 1 / sampleRate, keyframe.data.value.y);
                        keyframey.inTangent = keyframe.data.inSlope.y;
                        keyframey.outTangent = keyframe.data.outSlope.y;
                        keyframey.inWeight = keyframe.data.inWeight.y;
                        keyframey.outWeight = keyframe.data.outWeight.y;
                        keyframey.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                        animCurves[objname]["scaley"].AddKey(keyframey);
                        keyframez = new(animtime + 1 / sampleRate, keyframe.data.value.z);
                        keyframez.inTangent = keyframe.data.inSlope.z;
                        keyframez.outTangent = keyframe.data.outSlope.z;
                        keyframez.inWeight = keyframe.data.inWeight.z;
                        keyframez.outWeight = keyframe.data.outWeight.z;
                        keyframez.weightedMode = (WeightedMode)keyframe.data.weightedMode;
                        animCurves[objname]["scalez"].AddKey(keyframez);
                    }
                }
            }
        }
        foreach (AnimNodeHandler animNodeHandler in meigeAnimClipHolderJson.m_MeigeAnimClip.m_AnimNodeHandlerArray)
        {
            string name = animNodeHandler.m_Target.m_TargetName.Contains('/') ? animNodeHandler.m_Target.m_TargetName[(animNodeHandler.m_Target.m_TargetName.LastIndexOf('/') + 1)..] : animNodeHandler.m_Target.m_TargetName;
            List<Dictionary<Keyframe, int>> keyframes = new List<Dictionary<Keyframe, int>>();
            List<int> isNegative = new List<int> { 1, 1, 1, 1 };
            List<string> commandnames = new List<string>();
            switch (animNodeHandler.m_Target.m_TargetType)
            {
                case 6:
                    if (animNodeHandler.m_Target.m_Param2 == 0)
                    {
                        //commandnames=new List<string>{"rotation"};
                        commandnames = new List<string> { "offsetx" };
                    }
                    else
                    {
                        //commandnames=new List<string>{"rotation1"};
                        commandnames = new List<string> { "offsetx1" };
                    }
                    break;
                case 7:
                    if (animNodeHandler.m_Target.m_Param2 == 0)
                    {
                        commandnames = new List<string> { "offsetx", "offsety" };
                    }
                    else
                    {
                        commandnames = new List<string> { "offsetx1", "offsety1" };
                    }
                    break;
                case 9:
                    commandnames = new List<string> { "enabled" };
                    break;
                case 11:
                    break;
                case 12:
                    commandnames = new List<string> { "meshcolorr", "meshcolorg", "meshcolorb", "meshcolora" };
                    break;
                case 23:
                    if (animNodeHandler.m_Target.m_Param2 == 0)
                    {
                        commandnames = new List<string> { "matcolorr" };
                    }
                    else
                    {
                        commandnames = new List<string> { "matcolorr1" };
                    }
                    break;
                case 24:
                    if (animNodeHandler.m_Target.m_Param2 == 0)
                    {
                        commandnames = new List<string> { "matcolorg" };
                    }
                    else
                    {
                        commandnames = new List<string> { "matcolorg1" };
                    }
                    break;
                case 25:
                    if (animNodeHandler.m_Target.m_Param2 == 0)
                    {
                        commandnames = new List<string> { "matcolorb" };
                    }
                    else
                    {
                        commandnames = new List<string> { "matcolorb1" };
                    }
                    break;
                case 26:
                    if (animNodeHandler.m_Target.m_Param2 == 0)
                    {
                        commandnames = new List<string> { "matcolora" };
                    }
                    else
                    {
                        commandnames = new List<string> { "matcolora1" };
                    }
                    break;
                case 27:
                    if (animNodeHandler.m_Target.m_Param2 == 0)
                    {
                        commandnames = new List<string> { "tilingx" };
                    }
                    else
                    {
                        commandnames = new List<string> { "tilingx1" };
                    }
                    break;
                case 28:
                    if (animNodeHandler.m_Target.m_Param2 == 0)
                    {
                        commandnames = new List<string> { "tilingy" };
                    }
                    else
                    {
                        commandnames = new List<string> { "tilingy1" };
                    }
                    break;
                case 31:
                    if (animNodeHandler.m_Target.m_Param2 == 0)
                    {
                        commandnames = new List<string> { "offsetx" };
                    }
                    else
                    {
                        commandnames = new List<string> { "offsetx1" };
                    }
                    break;
                case 32:
                    if (animNodeHandler.m_Target.m_Param2 == 0)
                    {
                        commandnames = new List<string> { "offsety" };
                    }
                    else
                    {
                        commandnames = new List<string> { "offsety1" };
                    }
                    break;
                case 33:
                    commandnames = new List<string> { "meshcolorr" };
                    break;
                case 34:
                    commandnames = new List<string> { "meshcolorg" };
                    break;
                case 35:
                    commandnames = new List<string> { "meshcolorb" };
                    break;
                case 36:
                    commandnames = new List<string> { "meshcolora" };
                    break;
            }
            int count = 0;
            foreach (Curve curve in animNodeHandler.m_Curves)
            {
                foreach (ComponentCurve componentCurve in curve.m_ComponentCurves)
                {
                    keyframes.Add(new Dictionary<Keyframe, int>());
                    foreach (KeyData keyData in componentCurve.m_KeyDatas)
                    {
                        Keyframe keyframe = new(keyData.m_Frame / sampleRate, keyData.m_Value * isNegative[count]);
                        keyframe.inTangent = keyData.m_LeftDerivative;
                        keyframe.outTangent = keyData.m_RightDerivative;
                        keyframes[keyframes.Count - 1].Add(keyframe, keyData.m_CtrlType);
                    }
                    count++;
                }
            }
            List<List<Keyframe>> keyframesnew = new List<List<Keyframe>>();
            for (int i = 0; i < commandnames.Count; i++)
            {
                keyframesnew.Add(new List<Keyframe>());
                for (int j = 0; j < keyframes[i].Count; j++)
                {
                    Keyframe keyframe = new Keyframe(keyframes[i].Keys.ToArray()[j].time, keyframes[i].Keys.ToArray()[j].value);
                    keyframe.inTangent = keyframes[i].Keys.ToArray()[j].inTangent;
                    keyframe.outTangent = keyframes[i].Keys.ToArray()[j].outTangent;
                    if (keyframes[i].Values.ToArray()[j] == 0)
                    {
                        if (j > 0)
                        {
                            keyframe.inTangent = (keyframes[i].Keys.ToArray()[j].value - keyframes[i].Keys.ToArray()[j - 1].value) / (keyframes[i].Keys.ToArray()[j].time - keyframes[i].Keys.ToArray()[j - 1].time);
                        }
                        if (j < keyframes[i].Count - 1)
                        {
                            keyframe.outTangent = (keyframes[i].Keys.ToArray()[j].value - keyframes[i].Keys.ToArray()[j + 1].value) / (keyframes[i].Keys.ToArray()[j].time - keyframes[i].Keys.ToArray()[j + 1].time);
                        }
                    }
                    else if (keyframes[i].Values.ToArray()[j] == 2)
                    {
                        keyframe.inTangent = float.PositiveInfinity;
                        keyframe.outTangent = float.PositiveInfinity;
                    }
                    keyframesnew[keyframesnew.Count - 1].Add(keyframe);
                }
                foreach (Keyframe keyframe in keyframesnew[i])
                {
                    animCurves[name][commandnames[i]].AddKey(keyframe);
                }
            }
        }
        foreach (MsbMaterialHandler msbMaterialHandler in msbHandler.m_MsbMaterialHandlerArray)
        {
            foreach (MsbTexture msbTexture in msbMaterialHandler.m_Src.m_Texture)
            {
                webTexture[EffectID + @"\" + msbTexture.m_Name + ".png"].wrapModeU = TextureWrapMode.Repeat;
                webTexture[EffectID + @"\" + msbTexture.m_Name + ".png"].wrapModeV = TextureWrapMode.Repeat;
            }
        }
        foreach (GameObject efObjectDict in efObjects)
        {
            MeshRenderer meshRenderer = efObjectDict.GetComponent<MeshRenderer>();
            if (meshRenderer != null)
            {
                Material material = meshRenderer.sharedMaterial;
                MsbMaterialHandler efMaterialHandler = msbHandler.m_MsbMaterialHandlerArray.First(param => param.m_Name == material.name);
                Texture2D texture = webTexture[EffectID + @"\" + efMaterialHandler.m_Src.m_Texture[0].m_Name + ".png"];
                material.SetTexture(_MainTex, texture);
                if (efMaterialHandler.m_Src.m_Texture.Count == 2)
                {
                    Texture2D texturea = webTexture[EffectID + @"\" + efMaterialHandler.m_Src.m_Texture[1].m_Name + ".png"];
                    material.SetTexture(_AlphaTex, texturea);
                }
            }
            Dictionary<string, float> paddings;
            if (meshRenderer == null)
            {
                paddings = new Dictionary<string, float>(){
                    {"enabled",1f},
                    {"positionx",efObjectDict.transform.localPosition.x},
                    {"positiony",efObjectDict.transform.localPosition.y},
                    {"positionz",efObjectDict.transform.localPosition.z},
                    {"rotationx",efObjectDict.transform.localRotation.x},
                    {"rotationy",efObjectDict.transform.localRotation.y},
                    {"rotationz",efObjectDict.transform.localRotation.z},
                    {"rotationw",efObjectDict.transform.localRotation.w},
                    {"scalex",efObjectDict.transform.localScale.x},
                    {"scaley",efObjectDict.transform.localScale.y},
                    {"scalez",efObjectDict.transform.localScale.z},
                    {"meshcolorr",1f},
                    {"meshcolorg",1f},
                    {"meshcolorb",1f},
                    {"meshcolora",1f}
                };
            }
            else if (msbHandler.m_MsbObjectHandlerArray.FirstOrDefault(param => param.m_Name == efObjectDict.name) != null)
            {
                MsbObjectHandler msbParams = msbHandler.m_MsbObjectHandlerArray.First(param => param.m_Name == efObjectDict.name);
                paddings = new Dictionary<string, float>(){
                    {"enabled",1f},
                    {"positionx",efObjectDict.transform.localPosition.x},
                    {"positiony",efObjectDict.transform.localPosition.y},
                    {"positionz",efObjectDict.transform.localPosition.z},
                    {"rotationx",efObjectDict.transform.localRotation.x},
                    {"rotationy",efObjectDict.transform.localRotation.y},
                    {"rotationz",efObjectDict.transform.localRotation.z},
                    {"rotationw",efObjectDict.transform.localRotation.w},
                    {"scalex",efObjectDict.transform.localScale.x},
                    {"scaley",efObjectDict.transform.localScale.y},
                    {"scalez",efObjectDict.transform.localScale.z},
                    {"meshcolorr",msbParams.m_Src.m_MeshColor.r},
                    {"meshcolorg",msbParams.m_Src.m_MeshColor.g},
                    {"meshcolorb",msbParams.m_Src.m_MeshColor.b},
                    {"meshcolora",msbParams.m_Src.m_MeshColor.a}
                };
            }
            else
            {
                paddings = new Dictionary<string, float>(){
                    {"enabled",1f},
                    {"positionx",efObjectDict.transform.localPosition.x},
                    {"positiony",efObjectDict.transform.localPosition.y},
                    {"positionz",efObjectDict.transform.localPosition.z},
                    {"rotationx",efObjectDict.transform.localRotation.x},
                    {"rotationy",efObjectDict.transform.localRotation.y},
                    {"rotationz",efObjectDict.transform.localRotation.z},
                    {"rotationw",efObjectDict.transform.localRotation.w},
                    {"scalex",efObjectDict.transform.localScale.x},
                    {"scaley",efObjectDict.transform.localScale.y},
                    {"scalez",efObjectDict.transform.localScale.z},
                    {"meshcolorr",1f},
                    {"meshcolorg",1f},
                    {"meshcolorb",1f},
                    {"meshcolora",1f}
                };
            }
            foreach (string key in animCurves[efObjectDict.name].Keys)
            {
                if (animCurves[efObjectDict.name][key].length == 0)
                {
                    animCurves[efObjectDict.name][key].AddKey(new(0f, paddings[key]));
                }
            }
        }
        foreach (string efMaterial in efMaterials)
        {
            MsbMaterialHandler msbParams = msbHandler.m_MsbMaterialHandlerArray.First(param => param.m_Name == efMaterial);
            Dictionary<string, float> paddings = new Dictionary<string, float>(){
                {"tilingx",msbParams.m_Src.m_Texture[0].m_CoverageUV.x},
                {"tilingy",msbParams.m_Src.m_Texture[0].m_CoverageUV.y},
                {"offsetx",msbParams.m_Src.m_Texture[0].m_OffsetUV.x},
                {"offsety",msbParams.m_Src.m_Texture[0].m_OffsetUV.y},
                {"tilingx1",msbParams.m_Src.m_Texture[msbParams.m_Src.m_Texture.Count-1].m_CoverageUV.x},
                {"tilingy1",msbParams.m_Src.m_Texture[msbParams.m_Src.m_Texture.Count-1].m_CoverageUV.y},
                {"offsetx1",msbParams.m_Src.m_Texture[msbParams.m_Src.m_Texture.Count-1].m_OffsetUV.x},
                {"offsety1",msbParams.m_Src.m_Texture[msbParams.m_Src.m_Texture.Count-1].m_OffsetUV.y},
                {"matcolorr",1f},
                {"matcolorg",1f},
                {"matcolorb",1f},
                {"matcolora",1f},
                {"matcolorr1",1f},
                {"matcolorg1",1f},
                {"matcolorb1",1f},
                {"matcolora1",1f},
                {"rotation",0f},
                {"rotation1",0f},
            };
            foreach (string key in animCurves[efMaterial].Keys)
            {
                if (animCurves[efMaterial][key].length == 0)
                {
                    animCurves[efMaterial][key].AddKey(new(0f, paddings[key]));
                }
            }
        }
        yield return null;
        if (EffectEnding.Contains(ef) || ef == null) { yield break; }
        float timeElapsed = 0f;
        int SEIndex = 0;
        adveffectlist_Params efParam = effectLookup[EffectID];
        Dictionary<GameObject, MeshRenderer> efObjRenderers = new Dictionary<GameObject, MeshRenderer>();
        Dictionary<GameObject, Dictionary<string, AnimationCurve>> efObjCurves = new Dictionary<GameObject, Dictionary<string, AnimationCurve>>();
        foreach (GameObject efObject in efObjects)
        {
            MeshRenderer mr = efObject.GetComponent<MeshRenderer>();
            if (mr != null) { efObjRenderers[efObject] = mr; }
            efObjCurves[efObject] = animCurves[efObject.name];
        }
        Dictionary<string, Dictionary<string, AnimationCurve>> matCurvesCache = new Dictionary<string, Dictionary<string, AnimationCurve>>();
        foreach (string matName in efMaterials)
        {
            matCurvesCache[matName] = animCurves[matName];
        }
        Dictionary<GameObject, List<GameObject>> ptclUnits = new Dictionary<GameObject, List<GameObject>>();
        foreach (KeyValuePair<GameObject, RuleJson> ptcl in fPtcl)
        {
            ptclUnits.Add(ptcl.Key, new List<GameObject>());
        }
        Vector3 shift = new Vector3(0f, 0f, 0f);
        if (!isLoop)
        {
            while (timeElapsed < animtime)
            {
                if (EffectEnding.Contains(ef) || ef == null) { break; }
                timeElapsed += Time.deltaTime;
                foreach (GameObject efObject in efObjects)
                {
                    Dictionary<string, AnimationCurve> curves = efObjCurves[efObject];
                    if (efObject == ef)
                    {
                        float x = -curves["positionx"].Evaluate(timeElapsed);
                        float y = curves["positiony"].Evaluate(timeElapsed);
                        float cos = Mathf.Cos(Rotate * Mathf.Deg2Rad);
                        float sin = Mathf.Sin(Rotate * Mathf.Deg2Rad);
                        rectTransform.anchoredPosition = shift + new Vector3(X, Y, 0f) + multiple * new Vector3(x * cos - y * sin, x * sin + y * cos, curves["positionz"].Evaluate(timeElapsed));
                        rectTransform.localRotation = Quaternion.Euler(new Quaternion(curves["rotationx"].Evaluate(timeElapsed), curves["rotationy"].Evaluate(timeElapsed), curves["rotationz"].Evaluate(timeElapsed), curves["rotationw"].Evaluate(timeElapsed)).eulerAngles + new Vector3(0f, 180f, Rotate));
                        rectTransform.localScale = multiple * new Vector3(curves["scalex"].Evaluate(timeElapsed), curves["scaley"].Evaluate(timeElapsed), curves["scalez"].Evaluate(timeElapsed));
                        continue;
                    }
                    efObject.transform.localPosition = (efPtclParents.Contains(efObject) ? -shift / multiple : Vector3.zero) + new Vector3(curves["positionx"].Evaluate(timeElapsed), curves["positiony"].Evaluate(timeElapsed), curves["positionz"].Evaluate(timeElapsed));
                    efObject.transform.localRotation = new Quaternion(curves["rotationx"].Evaluate(timeElapsed), curves["rotationy"].Evaluate(timeElapsed), curves["rotationz"].Evaluate(timeElapsed), curves["rotationw"].Evaluate(timeElapsed));
                    efObject.transform.localScale = new Vector3(curves["scalex"].Evaluate(timeElapsed), curves["scaley"].Evaluate(timeElapsed), curves["scalez"].Evaluate(timeElapsed));
                    efObject.SetActive(curves["enabled"].Evaluate(timeElapsed) > 0f);
                    if (efObjRenderers.TryGetValue(efObject, out MeshRenderer cachedMR))
                    {
                        Material material = cachedMR.sharedMaterial;
                        Dictionary<string, AnimationCurve> matCurves = matCurvesCache[material.name];
                        material.SetColor(_MeshColor, new Color(curves["meshcolorr"].Evaluate(timeElapsed), curves["meshcolorg"].Evaluate(timeElapsed), curves["meshcolorb"].Evaluate(timeElapsed), curves["meshcolora"].Evaluate(timeElapsed)));
                        material.SetColor(_MatColor, new Color(matCurves["matcolorr"].Evaluate(timeElapsed), matCurves["matcolorg"].Evaluate(timeElapsed), matCurves["matcolorb"].Evaluate(timeElapsed), matCurves["matcolora"].Evaluate(timeElapsed)));
                        material.SetTextureScale(_MainTex, new Vector2(matCurves["tilingx"].Evaluate(timeElapsed), matCurves["tilingy"].Evaluate(timeElapsed)));
                        material.SetTextureOffset(_MainTex, new Vector2(matCurves["offsetx"].Evaluate(timeElapsed), -matCurves["offsety"].Evaluate(timeElapsed)));
                        material.SetTextureScale(_AlphaTex, new Vector2(matCurves["tilingx1"].Evaluate(timeElapsed), matCurves["tilingy1"].Evaluate(timeElapsed)));
                        material.SetTextureOffset(_AlphaTex, new Vector2(matCurves["offsetx1"].Evaluate(timeElapsed), -matCurves["offsety1"].Evaluate(timeElapsed)));
                    }
                }
                if (!isMuted && efParam.m_CueIDs.Count > SEIndex)
                {
                    if (timeElapsed > efParam.m_PlayFrames[SEIndex] / sampleRate)
                    {
                        PlaySE(efParam.m_CueIDs[SEIndex], 0f, 0f);
                        SEIndex++;
                    }
                }
                ProcessParticle(fPtcl, fPtclMat, fPtclRoot, ptclUnits, isCharaBehind, false, multiple);
                yield return null;
            }
            if (!EffectEnding.Contains(ef) && ef != null)
            {
                foreach (GameObject efObject in efObjects)
                {
                    Dictionary<string, AnimationCurve> curves = efObjCurves[efObject];
                    if (efObject == ef)
                    {
                        float x = -curves["positionx"].Evaluate(animtime);
                        float y = curves["positiony"].Evaluate(animtime);
                        float cos = Mathf.Cos(Rotate * Mathf.Deg2Rad);
                        float sin = Mathf.Sin(Rotate * Mathf.Deg2Rad);
                        rectTransform.anchoredPosition = shift + new Vector3(X, Y, 0f) + multiple * new Vector3(x * cos - y * sin, x * sin + y * cos, curves["positionz"].Evaluate(timeElapsed));
                        rectTransform.localRotation = Quaternion.Euler(new Quaternion(curves["rotationx"].Evaluate(animtime), curves["rotationy"].Evaluate(animtime), curves["rotationz"].Evaluate(animtime), curves["rotationw"].Evaluate(animtime)).eulerAngles + new Vector3(0f, 180f, Rotate));
                        rectTransform.localScale = multiple * new Vector3(curves["scalex"].Evaluate(animtime), curves["scaley"].Evaluate(animtime), curves["scalez"].Evaluate(animtime));
                        continue;
                    }
                    efObject.transform.localPosition = (efPtclParents.Contains(efObject) ? -shift / multiple : Vector3.zero) + new Vector3(curves["positionx"].Evaluate(animtime), curves["positiony"].Evaluate(animtime), curves["positionz"].Evaluate(animtime));
                    efObject.transform.localRotation = new Quaternion(curves["rotationx"].Evaluate(animtime), curves["rotationy"].Evaluate(animtime), curves["rotationz"].Evaluate(animtime), curves["rotationw"].Evaluate(animtime));
                    efObject.transform.localScale = new Vector3(curves["scalex"].Evaluate(animtime), curves["scaley"].Evaluate(animtime), curves["scalez"].Evaluate(animtime));
                    efObject.SetActive(curves["enabled"].Evaluate(animtime) > 0f);
                    if (efObjRenderers.TryGetValue(efObject, out MeshRenderer cachedMR2))
                    {
                        Material material = cachedMR2.sharedMaterial;
                        Dictionary<string, AnimationCurve> matCurves = matCurvesCache[material.name];
                        material.SetColor(_MeshColor, new Color(curves["meshcolorr"].Evaluate(animtime), curves["meshcolorg"].Evaluate(animtime), curves["meshcolorb"].Evaluate(animtime), curves["meshcolora"].Evaluate(animtime)));
                        material.SetColor(_MatColor, new Color(matCurves["matcolorr"].Evaluate(animtime), matCurves["matcolorg"].Evaluate(animtime), matCurves["matcolorb"].Evaluate(animtime), matCurves["matcolora"].Evaluate(animtime)));
                        material.SetTextureScale(_MainTex, new Vector2(matCurves["tilingx"].Evaluate(animtime), matCurves["tilingy"].Evaluate(animtime)));
                        material.SetTextureOffset(_MainTex, new Vector2(matCurves["offsetx"].Evaluate(animtime), -matCurves["offsety"].Evaluate(animtime)));
                        material.SetTextureScale(_AlphaTex, new Vector2(matCurves["tilingx1"].Evaluate(animtime), matCurves["tilingy1"].Evaluate(animtime)));
                        material.SetTextureOffset(_AlphaTex, new Vector2(matCurves["offsetx1"].Evaluate(animtime), -matCurves["offsety1"].Evaluate(animtime)));
                    }
                }
                ProcessParticle(fPtcl, fPtclMat, fPtclRoot, ptclUnits, isCharaBehind, false, multiple);
                yield return null;
            }
        }
        else
        {
            while (true)
            {
                if (EffectEnding.Contains(ef) || ef == null) { break; }
                if (animtime == 0f)
                {
                    timeElapsed = 0f;
                }
                else{
                    timeElapsed += Time.deltaTime;
                    while (timeElapsed > animtime)
                    {
                        timeElapsed -= animtime;
                    }
                }
                foreach (GameObject efObject in efObjects)
                {
                    Dictionary<string, AnimationCurve> curves = efObjCurves[efObject];
                    if (efObject == ef)
                    {
                        float x = -curves["positionx"].Evaluate(timeElapsed);
                        float y = curves["positiony"].Evaluate(timeElapsed);
                        float cos = Mathf.Cos(Rotate * Mathf.Deg2Rad);
                        float sin = Mathf.Sin(Rotate * Mathf.Deg2Rad);
                        rectTransform.anchoredPosition = shift + new Vector3(X, Y, 0f) + multiple * new Vector3(x * cos - y * sin, x * sin + y * cos, curves["positionz"].Evaluate(timeElapsed));
                        rectTransform.localRotation = Quaternion.Euler(new Quaternion(curves["rotationx"].Evaluate(timeElapsed), curves["rotationy"].Evaluate(timeElapsed), curves["rotationz"].Evaluate(timeElapsed), curves["rotationw"].Evaluate(timeElapsed)).eulerAngles + new Vector3(0f, 180f, Rotate));
                        rectTransform.localScale = multiple * new Vector3(curves["scalex"].Evaluate(timeElapsed), curves["scaley"].Evaluate(timeElapsed), curves["scalez"].Evaluate(timeElapsed));
                        continue;
                    }
                    efObject.transform.localPosition = (efPtclParents.Contains(efObject) ? -shift / multiple : Vector3.zero) + new Vector3(curves["positionx"].Evaluate(timeElapsed), curves["positiony"].Evaluate(timeElapsed), curves["positionz"].Evaluate(timeElapsed));
                    efObject.transform.localRotation = new Quaternion(curves["rotationx"].Evaluate(timeElapsed), curves["rotationy"].Evaluate(timeElapsed), curves["rotationz"].Evaluate(timeElapsed), curves["rotationw"].Evaluate(timeElapsed));
                    efObject.transform.localScale = new Vector3(curves["scalex"].Evaluate(timeElapsed), curves["scaley"].Evaluate(timeElapsed), curves["scalez"].Evaluate(timeElapsed));
                    efObject.SetActive(curves["enabled"].Evaluate(timeElapsed) > 0f);
                    if (efObjRenderers.TryGetValue(efObject, out MeshRenderer cachedMR3))
                    {
                        Material material = cachedMR3.sharedMaterial;
                        Dictionary<string, AnimationCurve> matCurves = matCurvesCache[material.name];
                        material.SetColor(_MeshColor, new Color(curves["meshcolorr"].Evaluate(timeElapsed), curves["meshcolorg"].Evaluate(timeElapsed), curves["meshcolorb"].Evaluate(timeElapsed), curves["meshcolora"].Evaluate(timeElapsed)));
                        material.SetColor(_MatColor, new Color(matCurves["matcolorr"].Evaluate(timeElapsed), matCurves["matcolorg"].Evaluate(timeElapsed), matCurves["matcolorb"].Evaluate(timeElapsed), matCurves["matcolora"].Evaluate(timeElapsed)));
                        material.SetTextureScale(_MainTex, new Vector2(matCurves["tilingx"].Evaluate(timeElapsed), matCurves["tilingy"].Evaluate(timeElapsed)));
                        material.SetTextureOffset(_MainTex, new Vector2(matCurves["offsetx"].Evaluate(timeElapsed), -matCurves["offsety"].Evaluate(timeElapsed)));
                        material.SetTextureScale(_AlphaTex, new Vector2(matCurves["tilingx1"].Evaluate(timeElapsed), matCurves["tilingy1"].Evaluate(timeElapsed)));
                        material.SetTextureOffset(_AlphaTex, new Vector2(matCurves["offsetx1"].Evaluate(timeElapsed), -matCurves["offsety1"].Evaluate(timeElapsed)));
                    }
                }
                ProcessParticle(fPtcl, fPtclMat, fPtclRoot, ptclUnits, isCharaBehind, true, multiple);
                yield return null;
            }
        }
        if (ef == null) { yield break; }
        while (ef != null && ProcessParticle(fPtcl, fPtclMat, fPtclRoot, ptclUnits, isCharaBehind, false, multiple))
        {
            yield return null;
        }
        if (ef == null) { yield break; }
        foreach (MeshRenderer meshRenderer in ef.GetComponentsInChildren<MeshRenderer>())
        {
            Destroy(meshRenderer);
        }
        Destroy(ef);
        foreach (GameObject ptclRoot in fPtclRoot.Values)
        {
            foreach (MeshRenderer meshRenderer in ptclRoot.GetComponentsInChildren<MeshRenderer>())
            {
                Destroy(meshRenderer);
            }
            Destroy(ptclRoot);
        }
        EffectEnding.Remove(ef);
    }
    private bool ProcessParticle(Dictionary<GameObject, RuleJson> fPtcl, Dictionary<GameObject, Material> fPtclMat, Dictionary<GameObject, GameObject> fPtclRoot, Dictionary<GameObject, List<GameObject>> ptclUnits, bool isCharaBehind, bool isLoop, float multiple)
    {
        if(!enableParticle){ return false; }
        bool isParticlePlaying = false;
        foreach (KeyValuePair<GameObject, RuleJson> ptcl in fPtcl)
        {
            RuleJson rule = ptcl.Value;
            GameObject ptclDummy = ptcl.Key;
            GameObject ptclRoot = fPtclRoot[ptcl.Key];
            float m_Time = Time.deltaTime * rule.m_frameSpeedScale;
            float m_FrameRate = Time.deltaTime / Time.fixedDeltaTime * rule.m_frameSpeedScale;
            float ptclCountRaw = m_Time * (rule.m_incidentNumberPerSec + UnityEngine.Random.Range(0f, 1f) * rule.m_incidentRandomLevel);
            int ptclCount = ptclCountRaw % 1 > UnityEngine.Random.Range(0f, 1f) ? (int)ptclCountRaw + 1 : (int)ptclCountRaw;
            if (!particleObjectParamsCache.TryGetValue(ptclDummy, out ParticleObjectParams particleObjectParams))
            {
                particleObjectParams = ptclDummy.GetComponent<ParticleObjectParams>();
                particleObjectParamsCache[ptclDummy] = particleObjectParams;
            }
            float coef = particleObjectParams.m_thisTransform.lossyScale.x;
            //float coef = multiple;
            if (particleObjectParams.m_Matrix.determinant == 0)
            {
                particleObjectParams.m_Matrix = particleObjectParams.m_thisTransform.localToWorldMatrix;
            }
            particleObjectParams.m_OldMatrix = particleObjectParams.m_Matrix;
            particleObjectParams.m_Matrix = particleObjectParams.m_thisTransform.localToWorldMatrix;
            if (rule.m_particleType == 3 && particleObjectParams.lines == null)
            {
                particleObjectParams.lines = new List<PrimPolyLine>();
                for (int i = 0; i < rule.m_particleNum; i++)
                {
                    PrimPolyLine primPolyLine = new PrimPolyLine();
                    primPolyLine.lines = new Line[rule.m_particleTypeParam.m_polyLine.m_jointNum + 2];
                    primPolyLine.widths = new float[rule.m_particleTypeParam.m_polyLine.m_jointNum + 2];
                    primPolyLine.UWidths = new float[rule.m_particleTypeParam.m_polyLine.m_jointNum + 2];
                    primPolyLine.positions = new Vector3[rule.m_particleTypeParam.m_polyLine.m_jointNum + 2];
                    primPolyLine.UVs = new Vector2[rule.m_particleTypeParam.m_polyLine.m_jointNum + 2];
                    primPolyLine.colors = new Color[rule.m_particleTypeParam.m_polyLine.m_jointNum + 2];
                    particleObjectParams.lines.Add(primPolyLine);
                }
            }
            for (int i = ptclUnits[ptclDummy].Count; i < ptclUnits[ptclDummy].Count + ptclCount; i++)
            {
                if (i >= rule.m_particleNum) { break; }
                GameObject gameObject = new GameObject("ptcl_" + i.ToString());
                ParticleUnitParams particleUnitParams = gameObject.AddComponent<ParticleUnitParams>();
                particleUnitParamsCache[gameObject] = particleUnitParams;
                particleUnitParams.m_Index = -1;
                gameObject.transform.SetParent(ptclRoot.transform);
                ptclUnits[ptclDummy].Add(gameObject);
            }
            for (int i = 0; i < ptclUnits[ptclDummy].Count; i++)
            {
                GameObject ptclUnit = ptclUnits[ptclDummy][i];
                if (ptclUnit == null) { continue; }
                ptclUnit.layer = isCharaBehind ? LayerMask.NameToLayer("Effect_CharaBehind") : LayerMask.NameToLayer("Effect");
                if (!particleUnitParamsCache.TryGetValue(ptclUnit, out ParticleUnitParams particleUnitParams))
                {
                    particleUnitParams = ptclUnit.GetComponent<ParticleUnitParams>();
                    particleUnitParamsCache[ptclUnit] = particleUnitParams;
                }
                if (particleUnitParams.m_Index == -1)
                {
                    Material material = fPtclMat[ptclDummy];
                    if (ptclUnit.GetComponent<MeshRenderer>() == null)
                    {
                        particleUnitParams.meshRenderer = ptclUnit.AddComponent<MeshRenderer>();
                    }
                    particleUnitParams.meshRenderer.material = material;
                    particleUnitParams.meshRenderer.sortingOrder = isCharaBehind ? -1099 : -99;
                    if (ptclUnit.GetComponent<MeshFilter>() == null)
                    {
                        if (rule.m_particleType == 3)
                        {
                            ptclUnit.AddComponent<MeshFilter>().mesh = new Mesh();
                        }
                        else
                        {
                            ptclUnit.AddComponent<MeshFilter>().mesh = CreateMesh(1f, 1f, new Vector2(0.5f, 0.5f));
                        }
                    }
                    particleUnitParams.m_Index = i;
                    particleUnitParams.m_particleType = rule.m_particleType;
                    particleUnitParams.m_scale = 1f;
                    particleUnitParams.m_lifeSpanType = rule.m_lifeSpanType;
                    particleUnitParams.m_lifeSpanRate = 0f;
                    particleUnitParams.m_lifeSpanFadeAlphaRate = 1f;
                    particleUnitParams.lastUpdateTime = Time.time;
                    switch (rule.m_emitionType)
                    {
                        case 0://eParticleEmitionType_Point
                            particleUnitParams.m_pos = new Vector3(0f, 0f, 0f);
                            particleUnitParams.m_velocity = Quaternion.Euler(UnityEngine.Random.Range(-180f, 180f), -90f, rule.m_emitionParam.m_point.m_angleRange.Random()) * Vector3.right;
                            break;
                        case 2://eParticleEmitionType_PlaneQuad
                            float x = UnityEngine.Random.Range(-0.5f, 0.5f) * rule.m_emitionParam.m_planeQuad.m_widthRange.m_Max.m_Value;
                            float y = UnityEngine.Random.Range(-0.5f, 0.5f) * rule.m_emitionParam.m_planeQuad.m_heightRange.m_Max.m_Value;
                            Vector3 pos = new Vector3(0f, 0f, 0f);
                            if (UnityEngine.Random.Range(0, 2) == 1)
                            {
                                pos.x = x;
                                pos.y = rule.m_emitionParam.m_planeQuad.m_heightRange.Random() * 0.5f * (UnityEngine.Random.Range(0, 2) * 2 - 1);
                            }
                            else
                            {
                                pos.x = rule.m_emitionParam.m_planeQuad.m_widthRange.Random() * 0.5f * (UnityEngine.Random.Range(0, 2) * 2 - 1);
                                pos.y = y;
                            }
                            pos.z = 0f;
                            particleUnitParams.m_pos = pos;
                            particleUnitParams.m_velocity = Vector3.forward;
                            break;
                        case 3://eParticleEmitionType_PlaneCircle
                            Vector3 pos2 = Quaternion.Euler(0f, 0f, UnityEngine.Random.Range(-180f, 180f)) * new Vector3(0f, rule.m_emitionParam.m_planeCircle.m_radiusRange.Random(), 0f);
                            particleUnitParams.m_pos = pos2;
                            particleUnitParams.m_velocity = Vector3.forward;
                            break;
                        case 4://eParticleEmitionType_Sphere
                            Quaternion rotation = Quaternion.Euler(UnityEngine.Random.Range(-180f, 180f), -90f, rule.m_emitionParam.m_sphere.m_angleRange.Random());
                            float radius = UnityEngine.Random.Range(0f, 1f);
                            radius = 1f - radius * radius;
                            Vector3 pos3 = rotation * new Vector3(rule.m_emitionParam.m_sphere.m_radiusRange.Lerp(radius), 0f, 0f);
                            particleUnitParams.m_pos = pos3;
                            particleUnitParams.m_velocity = rotation * Vector3.right;
                            break;
                    }
                    particleUnitParams.m_velocity *= rule.m_speedRange.Random();
                    particleUnitParams.m_lifeScaleMax = rule.m_lifeScaleRange.Random();
                    particleUnitParams.m_gravityForce = rule.m_gravityForceRange.Random() * rule.m_gravityDir * coef;
                    particleUnitParams.m_gravityForce.x = -particleUnitParams.m_gravityForce.x;
                    switch (rule.m_particleType)
                    {
                        case 0://eParticleType_Billboard
                            particleUnitParams.m_billboard = new Billboard();
                            float factor1 = UnityEngine.Random.Range(0f, 1f);
                            particleUnitParams.m_billboard.m_width = rule.m_particleTypeParam.m_billboard.m_widthRange.Lerp(factor1) * coef;
                            particleUnitParams.m_billboard.m_height = rule.m_particleTypeParam.m_billboard.m_heightRange.Lerp(factor1) * coef;
                            break;
                        case 3://eParticleType_PolyLine
                            particleUnitParams.m_polyLine = new PolyLine();
                            for (int j = 0; j < rule.m_particleTypeParam.m_polyLine.m_HistoryPointNum; j++)
                            {
                                particleUnitParams.m_polyLine.m_pPos[j] = particleUnitParams.m_pos;
                            }
                            if (rule.m_particleTypeParam.m_polyLine.m_HistoryPointNum == 0)
                            {
                                particleUnitParams.m_polyLine.m_HistoryPointNum = (short)(rule.m_particleTypeParam.m_polyLine.m_jointNum + 2);
                            }
                            else
                            {
                                particleUnitParams.m_polyLine.m_HistoryPointNum = (short)rule.m_particleTypeParam.m_polyLine.m_HistoryPointNum;
                            }
                            particleUnitParams.m_polyLine.m_pPos = new Vector3[particleUnitParams.m_polyLine.m_HistoryPointNum];
                            particleUnitParams.m_polyLine.m_jointNum = (short)rule.m_particleTypeParam.m_polyLine.m_jointNum;
                            float factor2 = UnityEngine.Random.Range(0f, 1f);
                            particleUnitParams.m_polyLine.m_topWidth = rule.m_particleTypeParam.m_polyLine.m_topWidthRange.Lerp(factor2) * coef;
                            particleUnitParams.m_polyLine.m_endWidth = rule.m_particleTypeParam.m_polyLine.m_endWidthRange.Lerp(factor2) * coef;
                            for (int j = 0; j < particleUnitParams.m_polyLine.m_HistoryPointNum; j++) {
                                particleUnitParams.m_polyLine.m_pPos[j] = particleUnitParams.m_pos;
                            }
                            PrimLineArray newLineArray = ptclUnit.AddComponent<PrimLineArray>();
                            int linePoints = particleUnitParams.m_polyLine.m_jointNum + 2;
                            int vertexCount = linePoints * 2;
                            int triangleCount = (linePoints - 1) * 6;
                            newLineArray.vertices = new Vector3[vertexCount];
                            newLineArray.uvs = new Vector2[vertexCount];
                            newLineArray.colors = new Color[vertexCount];
                            newLineArray.triangles = new int[triangleCount];
                            break;
                        case 4://eParticleType_Confetti
                            particleUnitParams.m_confetti = new Confetti();
                            float factor3 = UnityEngine.Random.Range(0f, 1f);
                            particleUnitParams.m_confetti.m_width = rule.m_particleTypeParam.m_confetti.m_widthRange.Lerp(factor3) * coef;
                            particleUnitParams.m_confetti.m_height = rule.m_particleTypeParam.m_confetti.m_heightRange.Lerp(factor3) * coef;
                            break;
                    }
                    switch (rule.m_lifeSpanType)
                    {
                        case 0://eParticleLifeSpanType_Time
                            particleUnitParams.m_lifeSpanParam[0] = rule.m_LifeSpanParam.m_Time.m_lifeSpanSecRange.Random();
                            break;
                        case 2://eParticleLifeSpanType_HeightRange
                            particleUnitParams.m_lifeSpanParam[0] = rule.m_LifeSpanParam.m_Height.m_lifeSpanHeightRange.m_Min.m_Value * coef;
                            particleUnitParams.m_lifeSpanParam[1] = rule.m_LifeSpanParam.m_Height.m_lifeSpanHeightRange.m_Max.m_Value * coef;
                            break;
                    }
                    particleUnitParams.m_activeFlg = true;
                    particleUnitParams.m_aliveCount = 0;
                    if (rule.m_isRandomEmitDir == 1)
                    {
                        particleUnitParams.m_velocity = Quaternion.Euler(UnityEngine.Random.Range(-180f, 180f), UnityEngine.Random.Range(-180f, 180f), 0f) * Vector3.forward;
                    }
                    Vector3 old = particleObjectParams.m_OldMatrix.MultiplyPoint(particleUnitParams.m_pos);
                    Vector3 young = particleObjectParams.m_Matrix.MultiplyPoint(particleUnitParams.m_pos);
                    particleUnitParams.m_pos = Vector3.Lerp(old, young, UnityEngine.Random.Range(0f, 1f));
                    particleUnitParams.m_birthPos = particleUnitParams.m_pos;
                    particleUnitParams.m_velocity = particleObjectParams.m_Matrix.MultiplyVector(particleUnitParams.m_velocity);
                    if (rule.m_UsingAccelerationFlg == 1)
                    {
                        particleUnitParams.m_AccelerationComponent = new AccelerationComponent();
                        particleUnitParams.m_AccelerationComponent.m_acceleration = rule.m_AccelerationComponent.m_accelerationRange.Random() * coef;
                        particleUnitParams.m_AccelerationComponent.m_dragForce = rule.m_AccelerationComponent.m_dragForceRange.Random();
                    }
                    if (rule.m_UsingRotationFlg == 1)
                    {
                        particleUnitParams.m_RotationComponent = new RotationComponent();
                        particleUnitParams.m_RotationComponent.m_rot.Set(rule.m_RotationComponent.m_rotRange.Random(), rule.m_RotationComponent.m_rotRange.Random(), rule.m_RotationComponent.m_rotRange.Random());
                        particleUnitParams.m_RotationComponent.m_rotAnchorOffset.Set(UnityEngine.Random.Range(0f, 1f) * rule.m_RotationComponent.m_rotAnchorOffsetRange.Random(), UnityEngine.Random.Range(0f, 1f) * rule.m_RotationComponent.m_rotAnchorOffsetRange.Random(), UnityEngine.Random.Range(0f, 1f) * rule.m_RotationComponent.m_rotAnchorOffsetRange.Random());
                        particleUnitParams.m_RotationComponent.m_rotAnchorOffset *= coef;
                        particleUnitParams.m_RotationComponent.m_rotVelocity.Set(rule.m_RotationComponent.m_rotSpeedRange.Random(), rule.m_RotationComponent.m_rotSpeedRange.Random(), rule.m_RotationComponent.m_rotSpeedRange.Random());
                        particleUnitParams.m_RotationComponent.m_rotAcceleration.Set(rule.m_RotationComponent.m_rotAccelerationRange.Random(), rule.m_RotationComponent.m_rotAccelerationRange.Random(), rule.m_RotationComponent.m_rotAccelerationRange.Random());
                        particleUnitParams.m_RotationComponent.m_rotDragForce = rule.m_RotationComponent.m_rotDragForceRange.Random();
                    }
                    if (rule.m_UsingUVAnimationFlg == 1)
                    {
                        particleUnitParams.m_UVAnimationComponent = new UVAnimationComponent();
                        particleUnitParams.m_UVAnimationComponent.m_nowBlock = (rule.m_uvBlockNum != 0) && (rule.m_UVAnimationComponent.m_randomStartBlockFlg == 1) ? UnityEngine.Random.Range(0, rule.m_uvBlockNum) : 0;
                        particleUnitParams.m_UVAnimationComponent.m_switchSec = rule.m_UVAnimationComponent.m_switchBlockSecRange.Random();
                        particleUnitParams.m_UVAnimationComponent.m_switchSecWork = particleUnitParams.m_UVAnimationComponent.m_switchSec;
                        particleUnitParams.m_uvRect = rule.m_uvRect_TopBlock;

                        if (particleUnitParams.m_UVAnimationComponent.m_nowBlock != 0)
                        {
                            int steps = particleUnitParams.m_UVAnimationComponent.m_nowBlock;
                            while (true)
                            {
                                if (particleUnitParams.m_uvRect.x + particleUnitParams.m_uvRect.width > 1f)
                                {
                                    particleUnitParams.m_uvRect.x = 0f;
                                    particleUnitParams.m_uvRect.y -= particleUnitParams.m_uvRect.height;
                                    if (particleUnitParams.m_uvRect.y - particleUnitParams.m_uvRect.height < 0f)
                                    {
                                        particleUnitParams.m_uvRect.y = rule.m_uvRect_TopBlock.y;
                                    }
                                }
                                if (steps == 0) { break; }
                                particleUnitParams.m_uvRect.x += particleUnitParams.m_uvRect.width;
                                steps--;
                            }
                        }
                    }
                    else
                    {
                        int steps = rule.m_uvBlockNum != 0 ? UnityEngine.Random.Range(0, rule.m_uvBlockNum) : 0;
                        particleUnitParams.m_uvRect = rule.m_uvRect_TopBlock;
                        if (steps != 0)
                        {
                            while (true)
                            {
                                if (particleUnitParams.m_uvRect.x + particleUnitParams.m_uvRect.width > 1f)
                                {
                                    particleUnitParams.m_uvRect.x = 0f;
                                    particleUnitParams.m_uvRect.y -= particleUnitParams.m_uvRect.height;
                                    if (particleUnitParams.m_uvRect.y - particleUnitParams.m_uvRect.height < 0f)
                                    {
                                        particleUnitParams.m_uvRect.y = rule.m_uvRect_TopBlock.y;
                                    }
                                }
                                if (steps == 0) { break; }
                                particleUnitParams.m_uvRect.x += particleUnitParams.m_uvRect.width;
                                steps--;
                            }
                        }
                    }
                    if (rule.m_UsingColorCurveFlg == 1)
                    {
                        particleUnitParams.m_ColorCurveComponent = new ColorCurveComponent();
                        if (rule.m_ColorCurveComponent.m_pColorCurveArray == null || rule.m_ColorCurveComponent.m_pColorCurveArray.Count == 0)
                        {
                            particleUnitParams.m_ColorCurveComponent.m_pColorCurve = null;
                        }
                        else
                        {
                            pColorCurveArray pColorCurveArray = rule.m_ColorCurveComponent.m_pColorCurveArray[UnityEngine.Random.Range(0, rule.m_ColorCurveComponent.m_pColorCurveArray.Count)];
                            Color[] colorsArray = new Color[pColorCurveArray.m_Value.Count];
                            for (int j = 0; j < pColorCurveArray.m_Value.Count; j++)
                            {
                                colorsArray[j] = pColorCurveArray.m_Value[j].m_Value;
                            }
                            particleUnitParams.m_ColorCurveComponent.m_pColorCurve = new RangeValueColor(colorsArray);
                        }
                    }
                    if (rule.m_UsingBlinkFlg == 1)
                    {
                        particleUnitParams.m_BlinkComponent = new BlinkComponent();
                        particleUnitParams.m_BlinkComponent.m_blinkRate = UnityEngine.Random.Range(0f, 1f);
                        particleUnitParams.m_BlinkComponent.m_blinkSpeed = rule.m_BlinkComponent.m_blinkSpanSecRange.Random();
                    }
                }
                if (!ptclUnit.activeSelf)
                {
                    continue;
                }
                else
                {
                    isParticlePlaying = true;
                }
                particleUnitParams.m_aliveCount += 1;
                if (rule.m_UsingAccelerationFlg == 1)
                {
                    Vector3 velocity = particleUnitParams.m_velocity;
                    if (velocity.sqrMagnitude > 0f)
                    {
                        velocity.Normalize();
                        particleUnitParams.m_velocity += particleUnitParams.m_AccelerationComponent.m_acceleration * m_Time * velocity;
                        particleUnitParams.m_velocity *= Mathf.Pow(particleUnitParams.m_AccelerationComponent.m_dragForce, m_FrameRate);
                    }
                }
                if (rule.m_UsingRotationFlg == 1)
                {
                    Vector3 rotVelocity = particleUnitParams.m_RotationComponent.m_rotVelocity;
                    if (rotVelocity.sqrMagnitude > 0f)
                    {
                        float force = Mathf.Min(1f, particleUnitParams.m_RotationComponent.m_rotDragForce);
                        rotVelocity.Normalize();
                        Vector3 addVelocity = particleUnitParams.m_RotationComponent.m_rotAcceleration * m_Time;
                        addVelocity.Scale(rotVelocity);
                        particleUnitParams.m_RotationComponent.m_rot += particleUnitParams.m_RotationComponent.m_rotVelocity * m_Time;
                        particleUnitParams.m_RotationComponent.m_rotVelocity += addVelocity;
                        particleUnitParams.m_RotationComponent.m_rotVelocity *= Mathf.Pow(force, m_FrameRate);
                    }
                }
                float factor;
                switch (rule.m_LifeScaleType)
                {
                    case 1:
                        factor = particleUnitParams.m_lifeSpanRate * particleUnitParams.m_lifeSpanRate;
                        break;
                    case 2:
                        factor = 1f - particleUnitParams.m_lifeSpanRate;
                        factor = 1f - factor * factor;
                        break;
                    default:
                        factor = particleUnitParams.m_lifeSpanRate;
                        break;
                }
                particleUnitParams.m_scale = Mathf.Lerp(1f, particleUnitParams.m_lifeScaleMax, factor);
                particleUnitParams.m_velocity += particleUnitParams.m_gravityForce * m_Time;
                if (rule.m_UsingUVAnimationFlg == 1)
                {
                    particleUnitParams.m_UVAnimationComponent.m_switchSecWork -= m_Time;
                    if (particleUnitParams.m_UVAnimationComponent.m_switchSecWork <= 0f)
                    {
                        particleUnitParams.m_UVAnimationComponent.m_switchSecWork = particleUnitParams.m_UVAnimationComponent.m_switchSec;
                        particleUnitParams.m_UVAnimationComponent.m_nowBlock = rule.m_uvBlockNum != 0 ? (particleUnitParams.m_UVAnimationComponent.m_nowBlock + 1) % rule.m_uvBlockNum : 0;
                        particleUnitParams.m_uvRect.x += particleUnitParams.m_uvRect.width;
                        if (particleUnitParams.m_uvRect.x + particleUnitParams.m_uvRect.width > 1f)
                        {
                            particleUnitParams.m_uvRect.x = 0f;
                            particleUnitParams.m_uvRect.y -= particleUnitParams.m_uvRect.height;
                            if (particleUnitParams.m_uvRect.y - particleUnitParams.m_uvRect.height < 0f)
                            {
                                particleUnitParams.m_uvRect.y = rule.m_uvRect_TopBlock.y;
                            }
                        }
                    }
                }
                float lifeRate = particleUnitParams.m_lifeSpanRate;
                switch (rule.m_lifeSpanType)
                {
                    case 0:
                        lifeRate = Mathf.Clamp(lifeRate + m_Time / particleUnitParams.m_lifeSpanParam[0], 0f, 1f);
                        break;
                    case 2:
                        float diff;
                        float offset;
                        if (particleUnitParams.m_pos.y >= particleUnitParams.m_birthPos.y)
                        {
                            diff = particleUnitParams.m_pos.y - particleUnitParams.m_birthPos.y;
                            offset = particleUnitParams.m_lifeSpanParam[1] - particleUnitParams.m_birthPos.y;
                        }
                        else
                        {
                            diff = particleUnitParams.m_birthPos.y - particleUnitParams.m_pos.y;
                            offset = particleUnitParams.m_birthPos.y - particleUnitParams.m_lifeSpanParam[0];
                        }
                        lifeRate = offset == 0f ? 1f : Mathf.Clamp(diff / offset, 0f, 1f);
                        break;
                }
                particleUnitParams.m_lifeSpanRate = lifeRate;
                float fadeRate = particleUnitParams.m_lifeSpanFadeAlphaRate;
                switch (rule.m_lifeSpanAlpha)
                {
                    case 0:
                        fadeRate = 1f;
                        break;
                    case 1:
                        if (lifeRate < 0.2f)
                        {
                            fadeRate = 1f - lifeRate / 0.2f;
                            fadeRate = 1f - fadeRate * fadeRate;
                        }
                        else if (lifeRate >= 0.8f)
                        {
                            fadeRate = (lifeRate - 0.8f) / 0.2f;
                            fadeRate = 1f - fadeRate * fadeRate;
                        }
                        else
                        {
                            fadeRate = 1f;
                        }
                        break;
                    case 2:
                        if (lifeRate < 0.2f)
                        {
                            fadeRate = 1f - lifeRate / 0.2f;
                            fadeRate = 1f - fadeRate * fadeRate;
                        }
                        else
                        {
                            fadeRate = 1f;
                        }
                        break;
                    case 3:
                        if (lifeRate >= 0.8f)
                        {
                            fadeRate = (lifeRate - 0.8f) / 0.2f;
                            fadeRate = 1f - fadeRate * fadeRate;
                        }
                        break;
                }
                particleUnitParams.m_lifeSpanFadeAlphaRate = fadeRate;
                if (rule.m_UsingColorCurveFlg == 1)
                {
                    if (particleUnitParams.m_ColorCurveComponent.m_pColorCurve != null)
                    {
                        particleUnitParams.m_color = particleUnitParams.m_ColorCurveComponent.m_pColorCurve.Lerp(particleUnitParams.m_lifeSpanRate);
                    }
                    else
                    {
                        particleUnitParams.m_color = Color.white;
                    }
                    particleUnitParams.m_color.a = particleUnitParams.m_color.a * particleUnitParams.m_lifeSpanFadeAlphaRate * rule.m_AlphaScale;
                }
                else
                {
                    particleUnitParams.m_color = Color.white;
                    particleUnitParams.m_color.a = particleUnitParams.m_color.a * particleUnitParams.m_lifeSpanFadeAlphaRate * rule.m_AlphaScale;
                }
                if (rule.m_UsingBlinkFlg == 1)
                {
                    particleUnitParams.m_BlinkComponent.m_blinkRate = Mathf.Repeat(particleUnitParams.m_BlinkComponent.m_blinkRate + m_Time / particleUnitParams.m_BlinkComponent.m_blinkSpeed, 2f);
                    float a = particleUnitParams.m_BlinkComponent.m_blinkRate <= 1f ? particleUnitParams.m_BlinkComponent.m_blinkRate : 2f - particleUnitParams.m_BlinkComponent.m_blinkRate;
                    particleUnitParams.m_color.a *= 1f - a * a * a * a;
                }
                float originalY = particleUnitParams.m_pos.y;
                if (rule.m_particleType != 5)
                {
                    particleUnitParams.m_pos += particleUnitParams.m_velocity * m_Time;
                }
                if (rule.m_collisionType == 1)
                {
                    float height = rule.m_collisionParam.m_height.m_height;
                    float add = 0;
                    if (originalY >= height && particleUnitParams.m_pos.y < height)
                    {
                        add = Mathf.Max(height - particleUnitParams.m_pos.y, 0.001f);
                    }
                    else if (originalY <= height && particleUnitParams.m_pos.y > height)
                    {
                        add = Mathf.Min(height - particleUnitParams.m_pos.y, -0.001f);
                    }
                    particleUnitParams.m_pos.y = height + add;
                    particleUnitParams.m_velocity.x *= rule.m_collisionParam.m_height.m_frictionCoefficient;
                    particleUnitParams.m_velocity.y = -particleUnitParams.m_velocity.y * rule.m_collisionParam.m_height.m_reflectionCoefficient;
                    particleUnitParams.m_velocity.z *= rule.m_collisionParam.m_height.m_frictionCoefficient;
                }
                if (rule.m_UsingRotationFlg == 1)
                {
                    int index = particleUnitParams.m_Index;
                    switch (particleUnitParams.m_particleType)
                    {
                        case 0:
                            {
                                Vector3 rotatedOffset = Quaternion.Euler(particleUnitParams.m_RotationComponent.m_rot) * particleUnitParams.m_RotationComponent.m_rotAnchorOffset;
                                ptclUnit.transform.position = particleUnitParams.m_pos + particleUnitParams.m_offset + rotatedOffset;
                                ptclUnit.transform.localScale = new Vector3(particleUnitParams.m_billboard.m_width * particleUnitParams.m_scale, particleUnitParams.m_billboard.m_height * particleUnitParams.m_scale, 1f);
                                ptclUnit.transform.rotation = cachedMainCameraTransform.rotation * Quaternion.AngleAxis(particleUnitParams.m_RotationComponent.m_rot.z, Vector3.forward);
                                particleUnitParams.meshRenderer.material.SetVector(_UVRect, new Vector4(particleUnitParams.m_uvRect.x, particleUnitParams.m_uvRect.y, particleUnitParams.m_uvRect.width, particleUnitParams.m_uvRect.height));
                                particleUnitParams.meshRenderer.material.SetColor(_MeshColor, particleUnitParams.m_color);
                                break;
                            }
                        case 4:
                            {
                                Vector3 rotatedOffset = Quaternion.Euler(particleUnitParams.m_RotationComponent.m_rot) * particleUnitParams.m_RotationComponent.m_rotAnchorOffset;
                                ptclUnit.transform.position = particleUnitParams.m_pos + particleUnitParams.m_offset + rotatedOffset;
                                ptclUnit.transform.localScale = new Vector3(particleUnitParams.m_confetti.m_width * particleUnitParams.m_scale, particleUnitParams.m_confetti.m_height * particleUnitParams.m_scale, 1f);
                                ptclUnit.transform.rotation = Quaternion.Euler(particleUnitParams.m_RotationComponent.m_rot) * ptclDummy.transform.rotation;
                                particleUnitParams.meshRenderer.material.SetVector(_UVRect, new Vector4(particleUnitParams.m_uvRect.x, particleUnitParams.m_uvRect.y, particleUnitParams.m_uvRect.width, particleUnitParams.m_uvRect.height));
                                particleUnitParams.meshRenderer.material.SetColor(_MeshColor, particleUnitParams.m_color);
                                break;
                            }
                    }

                }
                else
                {
                    int index = particleUnitParams.m_Index;
                    switch (particleUnitParams.m_particleType)
                    {
                        case 0:
                            ptclUnit.transform.position = particleUnitParams.m_pos + particleUnitParams.m_offset;
                            ptclUnit.transform.localScale = new Vector3(particleUnitParams.m_billboard.m_width * particleUnitParams.m_scale, particleUnitParams.m_billboard.m_height * particleUnitParams.m_scale, 1f);
                            ptclUnit.transform.rotation = cachedMainCameraTransform.rotation * Quaternion.AngleAxis(0f, Vector3.forward);
                            particleUnitParams.meshRenderer.material.SetVector(_UVRect, new Vector4(particleUnitParams.m_uvRect.x, particleUnitParams.m_uvRect.y, particleUnitParams.m_uvRect.width, particleUnitParams.m_uvRect.height));
                            particleUnitParams.meshRenderer.material.SetColor(_MeshColor, particleUnitParams.m_color);
                            break;
                        case 3:
                            float currentTime = Time.time;
                            if (currentTime - particleUnitParams.lastUpdateTime >= 1/30f)
                            {
                                particleUnitParams.lastUpdateTime += 1/30f;
                            }
                            else
                            {
                                break;
                            }
                            PrimPolyLine prim = particleObjectParams.lines[index];
                            int linePoints = particleUnitParams.m_polyLine.m_jointNum + 2;
                            int historyPoints = particleUnitParams.m_polyLine.m_HistoryPointNum;
                            for (int j = historyPoints - 1; j >= 1; j--)
                            {
                                particleUnitParams.m_polyLine.m_pPos[j] = particleUnitParams.m_polyLine.m_pPos[j - 1];
                            }
                            particleUnitParams.m_polyLine.m_pPos[0] = particleUnitParams.m_pos + particleUnitParams.m_offset;
                            if (historyPoints == linePoints)
                            {
                                for (int j = 0; j < linePoints; j++)
                                {
                                    prim.positions[j] = particleUnitParams.m_polyLine.m_pPos[j];
                                    prim.UVs[j] = new Vector2(particleUnitParams.m_uvRect.x + particleUnitParams.m_uvRect.width * j / (linePoints - 1), particleUnitParams.m_uvRect.y);
                                    prim.UWidths[j] = particleUnitParams.m_uvRect.height;
                                    PolyLine polyLine = particleUnitParams.m_polyLine;
                                    prim.widths[j] = Mathf.Lerp(polyLine.m_topWidth, polyLine.m_endWidth, j / (float)(polyLine.m_jointNum + 1)) * particleUnitParams.m_scale;
                                    if (particleUnitParams.m_aliveCount > j + 2)
                                    {
                                        prim.colors[j] = particleUnitParams.m_color;
                                    }
                                }
                            }
                            else
                            {
                                float points = Mathf.Max(linePoints / (float)historyPoints, 1f);
                                for (int j = 0; j < linePoints; j++)
                                {
                                    float pointFraction = j / (float)(linePoints - 1) * (historyPoints - 1);
                                    int point = (int)pointFraction;
                                    float Rate = pointFraction - point;
                                    float rateSqr = Rate * Rate;
                                    float rateCub = Rate * rateSqr;
                                    Vector3 vector4 = ((2f * rateSqr - rateCub - Rate) * particleUnitParams.m_polyLine.m_pPos[Mathf.Max(point - 1, 0)]
                                        + (3f * rateCub - 5f * rateSqr + 2f) * particleUnitParams.m_polyLine.m_pPos[point]
                                        + (4f * rateSqr - 3f * rateCub + Rate) * particleUnitParams.m_polyLine.m_pPos[Mathf.Min(point + 1, historyPoints - 1)]
                                        + (rateCub - rateSqr) * particleUnitParams.m_polyLine.m_pPos[Mathf.Min(point + 2, historyPoints - 1)]) * 0.5f;
                                    prim.positions[j] = vector4;
                                    prim.UVs[j] = new Vector2(particleUnitParams.m_uvRect.x + particleUnitParams.m_uvRect.width * j / (linePoints - 1), particleUnitParams.m_uvRect.y);
                                    prim.UWidths[j] = particleUnitParams.m_uvRect.height;
                                    PolyLine polyLine = particleUnitParams.m_polyLine;
                                    prim.widths[j] = Mathf.Lerp(polyLine.m_topWidth, polyLine.m_endWidth, j / (float)(polyLine.m_jointNum + 1)) * particleUnitParams.m_scale;
                                    if (particleUnitParams.m_aliveCount > j / points + 2f)
                                    {
                                        prim.colors[j] = particleUnitParams.m_color;
                                    }
                                }
                            }
                            int vertexCount = linePoints * 2;
                            int triangleCount = (linePoints - 1) * 6;
                            Mesh mesh = ptclUnit.GetComponent<MeshFilter>().mesh;
                            PrimLineArray lineArray = ptclUnit.GetComponent<PrimLineArray>();
                            Vector3[] vertices = lineArray.vertices;
                            Vector2[] uvs = lineArray.uvs;
                            Color[] colors = lineArray.colors;
                            int[] triangles = lineArray.triangles;
                            for (int j = 0; j < linePoints; j++)
                            {
                                Vector3 centerPos = prim.positions[j];
                                if (centerPos == Vector3.zero) centerPos = particleUnitParams.m_pos + particleUnitParams.m_offset;
                                Vector3 tangent;
                                if (j == 0) 
                                {
                                    tangent = prim.positions[1] - prim.positions[0];
                                }
                                else 
                                {
                                    tangent = prim.positions[j] - prim.positions[j - 1];
                                }
                                if (tangent.sqrMagnitude < 1e-6f) tangent = Vector3.right;
                                Vector3 normal = Vector3.Cross(tangent.normalized, Vector3.forward).normalized;
                                float halfWidth = prim.widths[j] * 0.5f;
                                int vIndex = j * 2;
                                vertices[vIndex]     = centerPos + normal * halfWidth;
                                vertices[vIndex + 1] = centerPos - normal * halfWidth;
                                uvs[vIndex]     = prim.UVs[j];
                                uvs[vIndex + 1] = new Vector2(prim.UVs[j].x, prim.UVs[j].y + prim.UWidths[j]); ;
                                colors[vIndex]     = prim.colors[j];
                                colors[vIndex + 1] = prim.colors[j];
                                if (j < linePoints - 1)
                                {
                                    int tIndex = j * 6;
                                    triangles[tIndex + 0] = vIndex;
                                    triangles[tIndex + 1] = vIndex + 3;
                                    triangles[tIndex + 2] = vIndex + 1;
                                    triangles[tIndex + 3] = vIndex;
                                    triangles[tIndex + 4] = vIndex + 2;
                                    triangles[tIndex + 5] = vIndex + 3;
                                }
                            }
                            mesh.Clear();
                            mesh.SetVertices(vertices, 0, vertexCount);
                            mesh.SetUVs(0, uvs, 0, vertexCount);
                            mesh.SetColors(colors, 0, vertexCount);
                            mesh.SetTriangles(triangles, 0, triangleCount, 0);
                            mesh.RecalculateBounds();
                            break;
                        case 4:
                            ptclUnit.transform.position = particleUnitParams.m_pos + particleUnitParams.m_offset;
                            ptclUnit.transform.localScale = new Vector3(particleUnitParams.m_confetti.m_width * particleUnitParams.m_scale, particleUnitParams.m_confetti.m_height * particleUnitParams.m_scale, 1f);
                            ptclUnit.transform.rotation = Quaternion.identity * ptclDummy.transform.rotation;
                            particleUnitParams.meshRenderer.material.SetVector(_UVRect, new Vector4(particleUnitParams.m_uvRect.x, particleUnitParams.m_uvRect.y, particleUnitParams.m_uvRect.width, particleUnitParams.m_uvRect.height));
                            particleUnitParams.meshRenderer.material.SetColor(_MeshColor, particleUnitParams.m_color);
                            break;
                    }
                }
                if (particleUnitParams.m_particleType == 0 || particleUnitParams.m_particleType == 4)
                {
                    ptclUnit.transform.rotation *= Quaternion.Euler(0f, 180f, 0f);
                }
                if (particleUnitParams.m_lifeSpanRate >= 1f)
                {
                    if (isLoop)
                    {
                        particleUnitParams.m_Index = -1;
                    }
                    else
                    {
                        particleUnitParams.m_activeFlg = false;
                        particleUnitParamsCache.Remove(ptclUnit);
                        Destroy(ptclUnit);
                    }
                    continue;
                }
            }
        }
        return isParticlePlaying;
    }
    private IEnumerator PlayEmotion(string ADVCharaID, string EmotionID, int EmoPosition)
    {
        GameObject chara = FindCached(ADVCharaID);
        if (chara == null) { yield break; }
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        advcharacterlist_Params param = GetCharaParams(ADVCharaID);
        advclist_Params_Data Pose = GetCharaParamsPose(ADVCharaID);
        advemotionlist_Params emoParam = emotionLookup[EmotionID];
        if (EmoPosition == 0) { EmoPosition = emoParam.m_DefaultPosition; }
        adveffectlist_Params efParam = effectLookup[emoParam.m_EffectID];
        GameObject ef = new GameObject(emoParam.m_EffectID);
        RectTransform rectTransform = ef.AddComponent<RectTransform>();
        rectTransform.anchorMax = new Vector2(0.5f, 0f);
        rectTransform.anchorMin = new Vector2(0.5f, 0f);
        string[] emo = new string[2] { ADVCharaID, EmotionID };
        Emotioning.Add(emo, ef);
        GameObject charaFace = FindCached(ADVCharaID + "_Face");
        Vector2 EmoOffset = new Vector2(Pose.m_FaceX, -Pose.m_FaceY);
        Texture2D texture;
        int FaceReferenceImageType = GetCharaParamsPoseFaceRefernceImageType(ADVCharaID);
        if (FaceReferenceImageType == 0)
        {
            texture = webTexture[param.m_ResourceBaseName + "_StandPic_" + Pose.m_PoseID];
        }
        else { texture = webTexture[param.m_ResourceBaseName + "_Face_" + Pose.m_PoseID + "_" + charaFaceID[charaProperties.FaceID]]; }
        EmoOffset += new Vector2(-texture.width / 2f, texture.height * (1 - Pose.m_FaceReferenceImageType * Pose.m_FacePivotY)); ;
        double a = Math.Cos(charaProperties.Angle * Mathf.Deg2Rad);
        double b = Math.Sin(charaProperties.Angle * Mathf.Deg2Rad);
        double x = charaProperties.RotateCenter.x * (1 - a) + charaProperties.RotateCenter.y * b + EmoOffset.x * a - EmoOffset.y * b;
        double y = charaProperties.RotateCenter.y * (1 - a) - charaProperties.RotateCenter.x * b + EmoOffset.y * a + EmoOffset.x * b;
        Vector2 EmoOffsetRotate = new Vector2(Pose.m_OffsetX + charaProperties.Position.x + (float)x, Pose.m_OffsetY + charaProperties.Position.y + (float)y);
        switch (EmoPosition)
        {
            case 1:
                EmoOffsetRotate += new Vector2(0, Pose.m_EmoOffsetY);
                break;
            case 2:
                EmoOffsetRotate += new Vector2(-Pose.m_EmoOffsetX, Pose.m_EmoOffsetY);
                break;
            case 3:
                EmoOffsetRotate += new Vector2(Pose.m_EmoOffsetX, Pose.m_EmoOffsetY);
                break;
            case 4:
                EmoOffsetRotate += new Vector2(Pose.m_FootOffsetX, Pose.m_FootOffsetY);
                break;
        }
        Coroutine coroutine = StartCoroutine(PlayEffect(ef, webGameObject[emoParam.m_EffectID], emoParam.m_EffectID, EmoOffsetRotate[0], EmoOffsetRotate[1], 0f, false, emoParam.m_Loop == 1, 750f, -600, false));
        yield return coroutine;
        Emotioning.Remove(emo);
    }
    private IEnumerator SetEffect(string EffectID, float x, float y, float rotation, bool isCharaBehind, bool isLoop, float multiple, float AnchorY, int sortingOrder, bool isMuted)
    {
        adveffectlist_Params efParam = effectLookup[EffectID];
        GameObject ef = new GameObject(EffectID);
        RectTransform rectTransform = ef.AddComponent<RectTransform>();
        rectTransform.anchorMax = new Vector2(0.5f, AnchorY);
        rectTransform.anchorMin = new Vector2(0.5f, AnchorY);
        if (Effecting.ContainsKey(EffectID))
        {
            Effecting[EffectID].Add(ef);
        }
        else { Effecting.Add(EffectID, new List<GameObject> { ef }); }
        Coroutine coroutine = StartCoroutine(PlayEffect(ef, webGameObject[EffectID], EffectID, x, y, rotation, isCharaBehind, isLoop, multiple, sortingOrder, isMuted));
        yield return coroutine;
        if (Effecting.ContainsKey(EffectID))
        {
            Effecting[EffectID].Remove(ef);
            if (Effecting[EffectID].Count == 0) { Effecting.Remove(EffectID); }
        }
    }
    private IEnumerator CreateEffectLoopTarget(string effectID, string afterEffectID, int StandPosition, float X, float Y, bool isCharaBehind)
    {
        Coroutine coroutine = CreateEffect(effectID, StandPosition, X, Y, 0f, isCharaBehind, false, 750f);
        yield return coroutine;
        CreateEffect(afterEffectID, StandPosition, X, Y, 0f, isCharaBehind, true, 750f);
    }
    private IEnumerator CreateEffectCharaLoopTarget(string effectID, string afterEffectID, string ADVCharaID, int CharaAnchor, float X, float Y, bool isCharaBehind)
    {
        Coroutine coroutine = CreateEffectChara(effectID, ADVCharaID, CharaAnchor, X, Y, 0f, isCharaBehind, false, 750f);
        yield return coroutine;
        CreateEffectChara(afterEffectID, ADVCharaID, CharaAnchor, X, Y, 0f, isCharaBehind, true, 750f);
    }
    private IEnumerator CreateEffectScreenLoopTarget(string effectID, string afterEffectID, int ScreenAnchor, float X, float Y, bool isCharaBehind)
    {
        Coroutine coroutine = CreateEffectScreen(effectID, ScreenAnchor, X, Y, 0f, isCharaBehind, false, 140.625f);
        yield return coroutine;
        CreateEffectScreen(afterEffectID, ScreenAnchor, X, Y, 0f, isCharaBehind, true, 140.625f);
    }
    private IEnumerator CreateEffectLoopWithPreset(int StandPosition, float X, float Y, float Rotate)
    {
        Coroutine coroutine = CreateEffect(EffectPreset[0], StandPosition, X, Y, Rotate, false, false, 333f);
        yield return coroutine;
        coroutine = CreateEffect(EffectPreset[1], StandPosition, X, Y, Rotate, false, false, 333f);
        yield return coroutine;
        CreateEffect(EffectPreset[2], StandPosition, X, Y, Rotate, false, false, 333f);
    }
    private IEnumerator CreateEffectCharaLoopWithPreset(string ADVCharaID, int CharaAnchor, float X, float Y, float Rotate)
    {
        Coroutine coroutine = CreateEffectChara(EffectPreset[0], ADVCharaID, CharaAnchor, X, Y, Rotate, false, false, 333f);
        yield return coroutine;
        coroutine = CreateEffectChara(EffectPreset[1], ADVCharaID, CharaAnchor, X, Y, Rotate, false, false, 333f);
        yield return coroutine;
        CreateEffectChara(EffectPreset[2], ADVCharaID, CharaAnchor, X, Y, Rotate, false, false, 333f);
    }
    private IEnumerator CreateEffectScreenLoopWithPreset(int Anchor, float X, float Y, float Rotate)
    {
        Coroutine coroutine = CreateEffectScreen(EffectPreset[0], Anchor, X, Y, Rotate, false, false, 333f);
        yield return coroutine;
        coroutine = CreateEffectScreen(EffectPreset[1], Anchor, X, Y, Rotate, false, false, 333f);
        yield return coroutine;
        CreateEffectScreen(EffectPreset[2], Anchor, X, Y, Rotate, false, false, 333f);
    }
    private IEnumerator WaitForEmotion(string ADVCharaID, string EmotionID)
    {
        Waiting.Add("WaitForEmotion");
        yield return null;
        string[] emo = new string[2] { ADVCharaID, EmotionID };
        while (true)
        {
            bool existing = false;
            foreach (string[] emo0 in Emotioning.Keys)
            {
                if (emo0[0] == emo[0] && emo0[1] == emo[1])
                {
                    existing = true;
                    break;
                }
            }
            if (existing)
            {
                yield return null;
            }
            else { break; }
        }
        Waiting.Remove("WaitForEmotion");
    }
    private IEnumerator WaitForEffect(string effectID)
    {
        Waiting.Add("WaitForEffect");
        yield return null;
        while (Effecting.ContainsKey(effectID))
        {
            yield return null;
        }
        Waiting.Remove("WaitForEffect");
    }
    private IEnumerator SetHDRFactorChara(string ADVCharaID, float Value, float Sec)
    {
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        float HDRStart = charaProperties.HDRFactor;
        yield return null;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            timeElapsed += Time.deltaTime;
            charaProperties.HDRFactor = Mathf.Lerp(HDRStart, Value, timeElapsed / Sec);
            isUpdateCharaHDRFactor.Add(ADVCharaID);
            yield return null;
        }
        charaProperties.HDRFactor = Value;
        isUpdateCharaHDRFactor.Add(ADVCharaID);
    }
    private IEnumerator ColorBlendLevelChange(float Value, float Sec)
    {
        Material mat = renderSpriteRenderer.material;
        float start = mat.GetFloat(_Level);
        yield return null;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            timeElapsed += Time.deltaTime;
            mat.SetFloat(_Level, Mathf.Lerp(start, Value, timeElapsed / Sec));
            yield return null;
        }
        mat.SetFloat(_Level, Value);
    }
    private IEnumerator DistorsionLevel_BGChange(float Value, float Sec)
    {
        Material mat = bgPrimObj.GetComponent<MeshRenderer>().material;
        float start = mat.GetFloat(_DistortionLevel);
        float DistortionLevel = start;
        yield return null;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            timeElapsed += Time.deltaTime;
            DistortionLevel = Mathf.Lerp(start, Value, timeElapsed / Sec);
            mat.SetFloat(_DistortionLevel, DistortionLevel);
            yield return null;
        }
        DistortionLevel = Value;
        mat.SetFloat(_DistortionLevel, DistortionLevel);
    }
    private IEnumerator BGDistortion()
    {
        Material mat = bgPrimObj.GetComponent<MeshRenderer>().material;
        float DistortionNoiseYOffset = 0;
        while (true)
        {
            DistortionNoiseYOffset += Time.deltaTime;
            DistortionNoiseYOffset %= 1;
            mat.SetVector(_NoiseTextureParam, new Vector4(0, DistortionNoiseYOffset, 1, 1));
            yield return null;
        }
    }
    private IEnumerator PrepareWarp(string ADVCharaID, float Sec)
    {
        if (warpPrepared.Contains(ADVCharaID)) { yield break; }
        warpPreparing.Add(ADVCharaID);
        GameObject chara = FindCached(ADVCharaID + "_RT");
        if (chara == null) { warpPreparing.Remove(ADVCharaID); yield break; }
        MeshRenderer meshRenderer = chara.GetComponent<MeshRenderer>();
        float start = charaPropertiesDict[ADVCharaID].HDRFactor;
        yield return null;
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            if (chara == null) { warpPreparing.Remove(ADVCharaID); yield break; }
            timeElapsed += Time.deltaTime;
            float HDRFactor = Mathf.Lerp(start, 0.9f, timeElapsed / Sec);
            meshRenderer.material.SetFloat(_HDRFactor, HDRFactor);
            yield return null;
        }
        if (chara == null) { warpPreparing.Remove(ADVCharaID); yield break; }
        meshRenderer.material.SetFloat(_HDRFactor, 0.9f);
        warpPreparing.Remove(ADVCharaID);
        warpPrepared.Add(ADVCharaID);
    }
    private IEnumerator Warp(string ADVCharaID, float Sec)
    {
        warpping.Add(ADVCharaID);
        GameObject chara = FindCached(ADVCharaID + "_RT");
        if (chara == null) { warpping.Remove(ADVCharaID); yield break; }
        MeshRenderer meshRenderer = chara.GetComponent<MeshRenderer>();
        yield return null;
        warpPrepared.Remove(ADVCharaID);
        float timeElapsed = 0f;
        while (timeElapsed < Sec)
        {
            if (chara == null) { warpping.Remove(ADVCharaID); yield break; }
            timeElapsed += Time.deltaTime;
            float ProgressRate = Mathf.Lerp(0f, 1f, timeElapsed / Sec);
            meshRenderer.material.SetFloat(_ProgressRate, ProgressRate);
            yield return null;
        }
        if (chara == null) { warpping.Remove(ADVCharaID); yield break; }
        meshRenderer.material.SetFloat(_ProgressRate, 1f);
        warpping.Remove(ADVCharaID);
    }
    private IEnumerator ShakeCanvas(int ShakeType, float time)
    {
        RectTransform rectTransform = canvas.GetComponent<RectTransform>();
        rectTransform = canvas.GetComponent<RectTransform>();
        float timeElapsed = 0f;
        int a = ShakeType % 3;
        int b = ShakeType / 3;
        int count = -1;
        float X = 0;
        float Y = 0;
        System.Random random = new System.Random();
        while (timeElapsed < time)
        {
            timeElapsed += Time.deltaTime;
            if (Math.Floor(timeElapsed / 0.1f) > count)
            {
                count++;
                if (b == 0)
                {
                    X = (float)random.NextDouble() * ShakeScale[a];
                    Y = (float)random.NextDouble() * ShakeScale[a];
                }
                else if (b == 1)
                {
                    X = count % 2 == 1 ? -ShakeScale[a] : ShakeScale[a];
                }
                else if (b == 2)
                {
                    Y = count % 2 == 1 ? -ShakeScale[a] : ShakeScale[a];
                }
                rectTransform.anchoredPosition = new Vector2(X, Y);
            }
            if (ShakeStopping)
            {
                rectTransform.anchoredPosition = new Vector2(0, 0);
                yield break;
            }
            yield return null;
        }
        rectTransform.anchoredPosition = new Vector2(0, 0);
    }
    private IEnumerator ShakeBGCoroutine(string bg, int ShakeType, float time)
    {
        BGProperties bgProperties = FindCached(bg).GetComponent<BGProperties>();
        float timeElapsed = 0f;
        int a = ShakeType % 3;
        int b = ShakeType / 3;
        int count = -1;
        float X = 0;
        float Y = 0;
        System.Random random = new System.Random();
        while (timeElapsed < time)
        {
            timeElapsed += Time.deltaTime;
            if (Math.Floor(timeElapsed / 0.1f) > count)
            {
                count++;
                if (b == 0)
                {
                    X = (float)random.NextDouble() * ShakeScale[a];
                    Y = (float)random.NextDouble() * ShakeScale[a];
                }
                else if (b == 1)
                {
                    X = count % 2 == 1 ? -ShakeScale[a] : ShakeScale[a];
                }
                else if (b == 2)
                {
                    Y = count % 2 == 1 ? -ShakeScale[a] : ShakeScale[a];
                }
                bgProperties.ShakeOffset = new Vector2(X, Y);
                isUpdateBGPosition = true;
            }
            if (ShakeStopping)
            {
                bgProperties.ShakeOffset = new Vector2(0, 0);
                isUpdateBGPosition = true;
                yield break;
            }
            yield return null;
        }
        bgProperties.ShakeOffset = new Vector2(0, 0);
        isUpdateBGPosition = true;
    }
    private IEnumerator ShakeCharaCoroutine(string ADVCharaID, int ShakeType, float time)
    {
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        float timeElapsed = 0f;
        int a = ShakeType % 3;
        int b = ShakeType / 3;
        int count = -1;
        float X = 0;
        float Y = 0;
        System.Random random = new System.Random();
        while (timeElapsed < time)
        {
            timeElapsed += Time.deltaTime;
            if (Math.Floor(timeElapsed / 0.1f) > count)
            {
                count++;
                if (b == 0)
                {
                    X = (float)random.NextDouble() * ShakeScale[a];
                    Y = (float)random.NextDouble() * ShakeScale[a];
                }
                else if (b == 1)
                {
                    X = count % 2 == 1 ? -ShakeScale[a] : ShakeScale[a];
                }
                else if (b == 2)
                {
                    Y = count % 2 == 1 ? -ShakeScale[a] : ShakeScale[a];
                }
                charaProperties.ShakeOffset = new Vector2(X, Y);
                isUpdateCharaPosition.Add(ADVCharaID);
            }
            if (ShakeStopping)
            {
                charaProperties.ShakeOffset = new Vector2(0f, 0f);
                isUpdateCharaPosition.Add(ADVCharaID);
                yield break;
            }
            yield return null;
        }
        charaProperties.ShakeOffset = new Vector2(0f, 0f);
        isUpdateCharaPosition.Add(ADVCharaID);
    }
    private IEnumerator StoppingShake()
    {
        ShakeStopping = true;
        yield return null;
        ShakeStopping = false;
    }
    private IEnumerator StoppingSE()
    {
        SEStopping = true;
        yield return null;
        SEStopping = false;
    }
    private IEnumerator StoppingVOICE()
    {
        VOICEStopping = true;
        yield return null;
        VOICEStopping = false;
    }
    private IEnumerator PlayTalkVoice(GameObject voice)
    {
        AudioSource audioSource = voice.GetComponent<AudioSource>();
        while (audioSource.clip == null) { yield return null; }
        audioSource.volume = VoiceVolume;
        audioSource.Play();
        float timeElapsed = 0f;
        int progress = advScriptProgress;
        while (timeElapsed < audioSource.clip.length && progress == advScriptProgress)
        {
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        Destroy(voice);
    }
    private IEnumerator AutoSkip(float sec)
    {
        while (autoWait.Count > 0)
        {
            yield return autoWait[0];
            autoWait.Remove(autoWait[0]);
        }
        switch (globalFont)
        {
            case "ja": yield return new WaitForSeconds(sec); break;
            case "zh": yield return new WaitForSeconds(sec * 1.5f); break;
            default: yield return new WaitForSeconds(sec); break;
        }
        autoClick = true;
    }
    private IEnumerator PlayBGMFadeIn(GameObject obj, float FadeInSec)
    {
        AudioSource audioSource = obj.GetComponent<AudioSource>();
        while (audioSource.clip == null) { yield return null; }
        audioSource.volume = 0f;
        audioSource.Play();
        float timeElapsed = 0f;
        while (timeElapsed < FadeInSec)
        {
            if (obj == null) { yield break; }
            timeElapsed += Time.deltaTime;
            float volume = Mathf.Lerp(0f, BGMVolume, timeElapsed / FadeInSec);
            audioSource.volume = volume;
            yield return null;
        }
        if (obj == null) { yield break; }
        audioSource.volume = BGMVolume;
    }
    private IEnumerator PlayBGMFadeOut(GameObject obj, float FadeOutSec)
    {
        AudioSource audioSource = obj.GetComponent<AudioSource>();
        audioSource.volume = BGMVolume;
        float timeElapsed = 0f;
        while (timeElapsed < FadeOutSec)
        {
            if (obj == null) { yield break; }
            timeElapsed += Time.deltaTime;
            float volume = Mathf.Lerp(BGMVolume, 0f, timeElapsed / FadeOutSec);
            audioSource.volume = volume;
            yield return null;
        }
        if (obj == null) { yield break; }
        audioSource.volume = 0f;
        Destroy(obj);
    }
    private IEnumerator PlaySEFade(GameObject obj)
    {
        AudioSource audioSource = obj.GetComponent<AudioSource>();
        while (audioSource.clip == null) { if (SEStopping) { Destroy(obj); yield break; } yield return null; }
        audioSource.volume = 0f;
        audioSource.Play();
        string objname = obj.name;
        SEPlaying.Add(obj, objname);
        float timeElapsed = 0f;
        float Length = audioSource.clip.length;
        audioSource.volume = SEVolume;
        while (timeElapsed < Length)
        {
            if (obj == null) { SEPlaying.Remove(obj); yield break; }
            if (SEStopping) { SEPlaying.Remove(obj); Destroy(obj); yield break; }
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        if (obj == null) { SEPlaying.Remove(obj); yield break; }
        audioSource.volume = 0f;
        SEPlaying.Remove(obj);
        Destroy(obj);
    }
    private IEnumerator PlaySELoop(GameObject obj, float FadeInSec, float FadeOutSec)
    {
        AudioSource audioSource = obj.GetComponent<AudioSource>();
        while (audioSource.clip == null) { if (SEStopping) { Destroy(obj); yield break; } yield return null; }
        audioSource.volume = 0f;
        audioSource.Play();
        string objname = obj.name;
        SEPlaying.Add(obj, objname);
        float timeElapsed = 0f;
        audioSource.volume = 0f;
        while (timeElapsed < FadeInSec)
        {
            if (obj == null) { SEPlaying.Remove(obj); yield break; }
            if (SEStopping) { break; }
            timeElapsed += Time.deltaTime;
            float volume = Mathf.Lerp(0f, SEVolume, timeElapsed / FadeInSec);
            audioSource.volume = volume;
            yield return null;
        }
        audioSource.volume = SEVolume;
        while (true)
        {
            if (obj == null) { SEPlaying.Remove(obj); yield break; }
            if (SEStopping) { break; }
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        timeElapsed = 0f;
        while (timeElapsed < FadeOutSec)
        {
            if (obj == null) { SEPlaying.Remove(obj); yield break; }
            timeElapsed += Time.deltaTime;
            float volume = Mathf.Lerp(SEVolume, 0f, timeElapsed / FadeOutSec);
            audioSource.volume = volume;
            yield return null;
        }
        if (obj == null) { SEPlaying.Remove(obj); yield break; }
        audioSource.volume = 0f;
        SEPlaying.Remove(obj);
        Destroy(obj);
    }
    private IEnumerator PlayVoice(GameObject voice)
    {
        AudioSource audioSource = voice.GetComponent<AudioSource>();
        while (audioSource.clip == null) { yield return null; }
        audioSource.volume = VoiceVolume;
        audioSource.Play();
        string voicename = voice.name;
        VOICEPlaying.Add(voicename);
        float timeElapsed = 0f;
        float Length = audioSource.clip.length;
        while (timeElapsed < Length)
        {
            if (VOICEStopping) { VOICEPlaying.Remove(voicename); Destroy(voice); yield break; }
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        VOICEPlaying.Remove(voicename);
        Destroy(voice);
    }
    private IEnumerator inputCD(float sec)
    {
        getInput = false;
        yield return new WaitForSeconds(sec);
        getInput = true;
    }
    private void BGVisible(uint ID, string FileNameWithoutExt)
    {
        GameObject bg;
        if (bgCoroutinesDict.ContainsKey(ID))
        {
            bg = FindCached("bg_" + ID.ToString());
            Texture2D texture = new Texture2D(0, 0);
            if (webTexture.ContainsKey(FileNameWithoutExt))
            {
                texture = webTexture[FileNameWithoutExt];
            }
            else
            {
                //Debug.LogError("Texture Not Found: "+FileNameWithoutExt);
            }
            texture.wrapMode = TextureWrapMode.Clamp;
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 1, 0, SpriteMeshType.FullRect);
            SpriteRenderer spriteRenderer = bg.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
            foreach (Coroutine coroutine in bgCoroutinesDict[ID].Values)
            {
                if (coroutine == null) { continue; }
                StopCoroutine(coroutine);
            }
            BGScaling.RemoveAll(item => item == ID);
            BGScrolling.RemoveAll(item => item == ID);
        }
        else
        {
            bg = new GameObject("bg_" + ID);
            CacheGameObject("bg_" + ID, bg);
            Texture2D texture = new Texture2D(0, 0);
            if (webTexture.ContainsKey(FileNameWithoutExt))
            {
                texture = webTexture[FileNameWithoutExt];
            }
            else
            {
                //Debug.LogError("Texture Not Found: "+FileNameWithoutExt);
            }
            texture.wrapMode = TextureWrapMode.Clamp;
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 1, 0, SpriteMeshType.FullRect);
            SpriteRenderer spriteRenderer = bg.AddComponent<SpriteRenderer>();
            spriteRenderer.material = new Material(Shader.Find("CustomShader_COMMON"));
            spriteRenderer.sprite = sprite;
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
            bg.AddComponent<RectTransform>();
            bg.AddComponent<BGProperties>();
            bgCoroutinesDict.Add(ID, new Dictionary<string, Coroutine> { { "scale", null }, { "scroll", null }, { "Distortion", null } });
            bg.layer = LayerMask.NameToLayer("BG_Prim");
        }
        string bgPath = FileNameWithoutExt;
        bg.transform.SetParent(canvas.transform);
        BGProperties bgProperties = bg.GetComponent<BGProperties>();
        bgProperties.ID = ID;
        bgProperties.Position = new Vector2(0f, 0f);
        bgProperties.Scale = 1;
        bg.GetComponent<SpriteRenderer>().sortingOrder = -2000 + (int)ID;
        RectTransform bgRect = bg.GetComponent<RectTransform>();
        bgRect.anchorMax = new Vector2(0.5f, 0.5f);
        bgRect.anchorMin = new Vector2(0.5f, 0.5f);
        bgRect.localPosition = new Vector3(0f, 0f, 0f);
        bgRect.localScale = new Vector3(0.6510415f, 0.6510415f, 1f);
    }
    private void SetCharaShotPosition(int ADVCharaPos, int ADVCharaPos2, int ADVCharaPos3, int ADVCharaPos4, int ADVCharaPos5)
    {
        CharaShots[0] = ADVCharaPos;
        if (CharaShots[0] == ADVCharaPos2)
        {
            CharaShots[1] = -1;
        }
        else { CharaShots[1] = ADVCharaPos2; }
        if (CharaShots[0] == ADVCharaPos3 || CharaShots[1] == ADVCharaPos3)
        {
            CharaShots[2] = -1;
        }
        else { CharaShots[2] = ADVCharaPos3; }
        if (CharaShots[0] == ADVCharaPos4 || CharaShots[1] == ADVCharaPos4 || CharaShots[2] == ADVCharaPos4)
        {
            CharaShots[3] = -1;
        }
        else { CharaShots[3] = ADVCharaPos4; }
        if (CharaShots[0] == ADVCharaPos5 || CharaShots[1] == ADVCharaPos5 || CharaShots[2] == ADVCharaPos5 || CharaShots[3] == ADVCharaPos5)
        {
            CharaShots[4] = -1;
        }
        else { CharaShots[4] = ADVCharaPos5; }
    }
    private void CharaShot(string ADVCharaID, string ADVCharaID2, string ADVCharaID3, string ADVCharaID4, string ADVCharaID5)
    {
        foreach (string chara in CharasExist.Keys)
        {
            if (charaCoroutinesDict[chara]["destroy"] != null) { StopCoroutine(charaCoroutinesDict[chara]["destroy"]); }
            charaCoroutinesDict[chara]["destroy"] = StartCoroutine(DestroyAfterAnimation(chara, new List<Coroutine> { }));
        }
        string[] ADVCharaIDs = new string[5] { ADVCharaID, ADVCharaID2, ADVCharaID3, ADVCharaID4, ADVCharaID5 };
        for (int i = 0; i < 5; i++)
        {
            if (GetCharaParams(ADVCharaIDs[i]) != null && CharaShots[i] != -1)
            {
                CreateStandpic(ADVCharaIDs[i]);
                CharaSetPosition(ADVCharaIDs[i], charaShotPx[CharaShots[i]], 0);
                charaPropertiesDict[ADVCharaIDs[i]].Fade = 1f;
                isUpdateCharaFade.Add(ADVCharaIDs[i]);
            }
        }
    }
    private void CharaIn(string ADVCharaID, int StandPosition)
    {
        CreateStandpic(ADVCharaID);
        CharaSetPosition(ADVCharaID, charaShotPx[StandPosition], 0);
        charaPropertiesDict[ADVCharaID].Fade = 1f;
        isUpdateCharaFade.Add(ADVCharaID);
    }
    private void CharaIn(string ADVCharaID, int StandPosition, int StartSide, float Sec, int CurveType, float XOffset)
    {
        CreateStandpic(ADVCharaID);
        CharaSetPosition(ADVCharaID, charaShotPx[StartSide == 0 ? -1 : -2], 0);
        charaPropertiesDict[ADVCharaID].Fade = 1f;
        isUpdateCharaFade.Add(ADVCharaID);
        StartCoroutine(CharaMoveTo(ADVCharaID, charaShotPx[StandPosition] + XOffset, 0, Sec, CurveType));
    }
    private void CharaOut(string ADVCharaID)
    {
        if (!CharasExist.ContainsKey(ADVCharaID)) { return; }
        if (charaCoroutinesDict[ADVCharaID]["destroy"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["destroy"]); }
        charaCoroutinesDict[ADVCharaID]["destroy"] = StartCoroutine(DestroyAfterAnimation(ADVCharaID, new List<Coroutine> { }));
    }
    private void CharaOut(string ADVCharaID, int EndSide, float Sec, int CurveType)
    {
        if (!CharasExist.ContainsKey(ADVCharaID)) { return; }
        Coroutine MoveCoroutine = StartCoroutine(CharaMoveTo(ADVCharaID, charaShotPx[EndSide == 0 ? -1 : -2], 0, Sec, CurveType));
        if (charaCoroutinesDict[ADVCharaID]["move"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["move"]); }
        charaCoroutinesDict[ADVCharaID]["move"] = MoveCoroutine;
        if (charaCoroutinesDict[ADVCharaID]["destroy"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["destroy"]); }
        charaCoroutinesDict[ADVCharaID]["destroy"] = StartCoroutine(DestroyAfterAnimation(ADVCharaID, new List<Coroutine> { MoveCoroutine }));
    }
    private void CharaOutAll()
    {
        foreach (string ADVCharaID in new List<string>(CharasExist.Keys))
        {
            if (charaCoroutinesDict[ADVCharaID]["destroy"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["destroy"]); }
            charaCoroutinesDict[ADVCharaID]["destroy"] = StartCoroutine(DestroyAfterAnimation(ADVCharaID, new List<Coroutine> { }));
        }
    }
    private void CharaInFade(string ADVCharaID, int StandPosition, float Sec)
    {
        CreateStandpic(ADVCharaID);
        CharaSetPosition(ADVCharaID, charaShotPx[StandPosition], 0);
        if (charaCoroutinesDict[ADVCharaID]["fade"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["fade"]); }
        charaCoroutinesDict[ADVCharaID]["fade"] = StartCoroutine(CharaFade(ADVCharaID, 0f, 1f, Sec));
    }
    private void CharaInFade(string ADVCharaID, int StandPosition, float Sec, int StartSide, int CurveType, float XOffset)
    {
        CreateStandpic(ADVCharaID);
        CharaSetPosition(ADVCharaID, charaShotPx[StartSide == 0 ? -1 : -2], 0);
        if (charaCoroutinesDict[ADVCharaID]["fade"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["fade"]); }
        charaCoroutinesDict[ADVCharaID]["fade"] = StartCoroutine(CharaFade(ADVCharaID, 0f, 1f, Sec));
        if (charaCoroutinesDict[ADVCharaID]["move"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["move"]); }
        charaCoroutinesDict[ADVCharaID]["move"] = StartCoroutine(CharaMoveTo(ADVCharaID, charaShotPx[StandPosition] + XOffset * 2, 0, Sec, CurveType));
    }
    private void CharaOutFade(string ADVCharaID, float Sec)
    {
        GameObject chara = FindCached(ADVCharaID);
        if (chara != null)
        {
            Coroutine FadeCoroutine = StartCoroutine(CharaFade(ADVCharaID, charaPropertiesDict[ADVCharaID].Fade, 0f, Sec));
            if (charaCoroutinesDict[ADVCharaID]["fade"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["fade"]); }
            charaCoroutinesDict[ADVCharaID]["fade"] = FadeCoroutine;
            if (charaCoroutinesDict[ADVCharaID]["destroy"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["destroy"]); }
            charaCoroutinesDict[ADVCharaID]["destroy"] = StartCoroutine(DestroyAfterAnimation(ADVCharaID, new List<Coroutine> { FadeCoroutine }));
        }
    }
    private void CharaOutFade(string ADVCharaID, float Sec, int EndSide, int CurveType)
    {
        GameObject chara = FindCached(ADVCharaID);
        if (chara != null)
        {
            Coroutine FadeCoroutine = StartCoroutine(CharaFade(ADVCharaID, charaPropertiesDict[ADVCharaID].Fade, 0f, Sec));
            Coroutine MoveCoroutine = StartCoroutine(CharaMoveTo(ADVCharaID, charaShotPx[EndSide == 0 ? -1 : -2], 0, Sec, CurveType));
            if (charaCoroutinesDict[ADVCharaID]["fade"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["fade"]); }
            charaCoroutinesDict[ADVCharaID]["fade"] = FadeCoroutine;
            if (charaCoroutinesDict[ADVCharaID]["move"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["move"]); }
            charaCoroutinesDict[ADVCharaID]["move"] = MoveCoroutine;
            if (charaCoroutinesDict[ADVCharaID]["destroy"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["destroy"]); }
            charaCoroutinesDict[ADVCharaID]["destroy"] = StartCoroutine(DestroyAfterAnimation(ADVCharaID, new List<Coroutine> { FadeCoroutine, MoveCoroutine }));
        }
    }
    private void CharaShotFade(string ADVCharaID, string ADVCharaID2, string ADVCharaID3, string ADVCharaID4, string ADVCharaID5, float Sec)
    {
        foreach (string chara in CharasExist.Keys)
        {
            if (charaCoroutinesDict[chara]["destroy"] != null) { StopCoroutine(charaCoroutinesDict[chara]["destroy"]); }
            charaCoroutinesDict[chara]["destroy"] = StartCoroutine(DestroyAfterAnimation(chara, new List<Coroutine> { }));
        }
        string[] ADVCharaIDs = new string[5] { ADVCharaID, ADVCharaID2, ADVCharaID3, ADVCharaID4, ADVCharaID5 };
        for (int i = 0; i < 5; i++)
        {
            if (GetCharaParams(ADVCharaIDs[i]) != null && CharaShots[i] != -1)
            {
                CreateStandpic(ADVCharaIDs[i]);
                CharaSetPosition(ADVCharaIDs[i], charaShotPx[CharaShots[i]], 0);
                if (charaCoroutinesDict[ADVCharaIDs[i]]["fade"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaIDs[i]]["fade"]); }
                charaCoroutinesDict[ADVCharaIDs[i]]["fade"] = StartCoroutine(CharaFade(ADVCharaIDs[i], 0f, 1f, Sec));
            }
        }
    }
    private void CharaOutAllFade(float Sec)
    {
        foreach (string ADVCharaID in CharasExist.Keys)
        {
            GameObject chara = FindCached(ADVCharaID);
            Coroutine FadeCoroutine = StartCoroutine(CharaFade(ADVCharaID, charaPropertiesDict[ADVCharaID].Fade, 0f, Sec));
            if (charaCoroutinesDict[ADVCharaID]["fade"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["fade"]); }
            charaCoroutinesDict[ADVCharaID]["fade"] = FadeCoroutine;
            if (charaCoroutinesDict[ADVCharaID]["destroy"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["destroy"]); }
            charaCoroutinesDict[ADVCharaID]["destroy"] = StartCoroutine(DestroyAfterAnimation(ADVCharaID, new List<Coroutine> { FadeCoroutine }));
        }
    }
    private void CharaPosition(string ADVCharaID, int StandPosition, float Xoffset, float Yoffset)
    {
        if (charaCoroutinesDict[ADVCharaID]["move"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["move"]); }
        charaCoroutinesDict[ADVCharaID]["move"] = StartCoroutine(CharaMoveTo(ADVCharaID, charaShotPx[StandPosition] + Xoffset, Yoffset, 0, 0));
    }
    private void CharaMove(string ADVCharaID, int StandPosition, float Xoffset, float Yoffset, float Sec, int CurveType)
    {
        if (charaCoroutinesDict[ADVCharaID]["move"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["move"]); }
        charaCoroutinesDict[ADVCharaID]["move"] = StartCoroutine(CharaMoveTo(ADVCharaID, charaShotPx[StandPosition] + Xoffset, Yoffset, Sec, CurveType));
    }
    private void CharaFace(string ADVCharaID, int FaceID)
    {
        FaceID = FaceID == -1 ? 0 : FaceID;
        if (charaPropertiesDict.ContainsKey(ADVCharaID))
        {
            charaPropertiesDict[ADVCharaID].FaceID = FaceID;
            isUpdateCharaFaceTexture.Add(ADVCharaID);
        }
    }
    private void CharaPose(string ADVCharaID, string PoseName)
    {
        charaPropertiesDict[ADVCharaID].PoseID = GetCharaParams(ADVCharaID).m_Datas.First(param => param.m_PoseName == PoseName).m_PoseID;
        isUpdateCharaPose.Add(ADVCharaID);
        isUpdateCharaFace.Add(ADVCharaID);
        isUpdateCharaFaceTexture.Add(ADVCharaID);
        isUpdateCharaPosition.Add(ADVCharaID);
        isUpdateCharaFade.Add(ADVCharaID);
    }
    private void CharaMot(string ADVCharaID, string MotID)
    {
        if (charaCoroutinesDict[ADVCharaID]["mot"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["mot"]); }
        charaCoroutinesDict[ADVCharaID]["mot"] = StartCoroutine(CharaMoting(ADVCharaID, MotID));
    }
    private void CharaHighlight(string ADVCharaID)
    {
        forceHighlight.Add(ADVCharaID);
        if (forceShading.Contains(ADVCharaID))
        {
            forceShading.Remove(ADVCharaID);
        }
        isUpdateHighlight = true;
    }
    private void CharaHighlightAll()
    {
        forceHighlight = new List<string>(CharasExist.Keys);
        forceShading = new List<string>();
        isUpdateHighlight = true;
    }
    private void CharaHighlightReset(string ADVCharaID)
    {
        if (forceHighlight.Contains(ADVCharaID))
        {
            forceHighlight.Remove(ADVCharaID);
        }
        if (forceShading.Contains(ADVCharaID))
        {
            forceShading.Remove(ADVCharaID);
        }
        isUpdateHighlight = true;
    }
    private void CharaHighlightResetAll()
    {
        forceHighlight = new List<string>();
        forceShading = new List<string>();
        talkingChara = new List<string>();
        isUpdateHighlight = true;
    }
    private void CharaShading(string ADVCharaID)
    {
        forceShading.Add(ADVCharaID);
        if (forceHighlight.Contains(ADVCharaID))
        {
            forceHighlight.Remove(ADVCharaID);
        }
        isUpdateHighlight = true;
    }
    private void CharaShadingAll()
    {
        forceShading = new List<string>(CharasExist.Keys);
        forceHighlight = new List<string>();
        isUpdateHighlight = true;
    }
    private void CharaPriorityTop(string ADVCharaID)
    {
        charaPriorityMid.Remove(ADVCharaID);
        charaPriorityMid.Add(ADVCharaID);
        isUpdatePriority = true;
    }
    private void CharaPriorityTopSet(string ADVCharaID)
    {
        charaPriorityMid.Remove(ADVCharaID);
        charaPriorityFirst.Add(ADVCharaID);
        isUpdatePriority = true;
    }
    private void CharaPriorityBottom(string ADVCharaID)
    {
        charaPriorityMid.Remove(ADVCharaID);
        charaPriorityMid.Insert(0, ADVCharaID);
        isUpdatePriority = true;
    }
    private void CharaPriorityBottomSet(string ADVCharaID)
    {
        charaPriorityMid.Remove(ADVCharaID);
        charaPriorityLast.Add(ADVCharaID);
        isUpdatePriority = true;
    }
    private void CharaPriorityReset(string ADVCharaID)
    {
        if (charaPriorityFirst.Contains(ADVCharaID))
        {
            charaPriorityFirst.Remove(ADVCharaID);
        }
        if (charaPriorityMid.Contains(ADVCharaID))
        {
            charaPriorityMid.Remove(ADVCharaID);
        }
        if (charaPriorityLast.Contains(ADVCharaID))
        {
            charaPriorityLast.Remove(ADVCharaID);
        }
        charaPriorityMid.Add(ADVCharaID);
        isUpdatePriority = true;
    }
    private void Fade(string RGBAStart, string RGBAEnd, float Sec, int CurveType)
    {
        StartCoroutine(ImageFade(RGBAStart, RGBAEnd, Sec, CurveType));
        isUpdateHighlight = true;
    }
    private void FadeIn(string RGBA, float Sec)
    {
        StartCoroutine(ImageFadeIn(RGBA, Sec));
        isUpdatePriority = true;
        isUpdateHighlight = true;
    }
    private void FadeOut(string RGBA, float Sec)
    {
        StartCoroutine(ImageFadeOut(RGBA, Sec));
        isUpdateHighlight = true;
    }
    private void Wait(float Sec)
    {
        StartCoroutine(WaitForSec(Sec));
    }
    private void WaitFade()
    {
        StartCoroutine(WaitForFade());
    }
    private void WaitMotion()
    {
        StartCoroutine(WaitForMotion());
    }
    private void WaitCharaMove()
    {
        StartCoroutine(WaitForCharaMove());
    }
    private void WaitCharaFade()
    {
        StartCoroutine(WaitForCharaFade());
    }
    private void WaitBGScroll(uint ID)
    {
        StartCoroutine(WaitForBGScroll(ID));
    }
    private void WaitBGScroll()
    {
        foreach (uint bgID in BGScrolling) { StartCoroutine(WaitForBGScale(bgID)); }
    }
    private void WaitBGScale(uint ID)
    {
        StartCoroutine(WaitForBGScale(ID));
    }
    private void WaitBGScale()
    {
        foreach (uint bgID in BGScaling) { StartCoroutine(WaitForBGScale(bgID)); }
    }
    private void CharaTransparency(string ADVCharaID, uint Alpha, float Sec, int CurveType)
    {
        float a = Alpha / 255f;
        if (charaCoroutinesDict[ADVCharaID]["transparency"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["transparency"]); }
        charaCoroutinesDict[ADVCharaID]["transparency"] = StartCoroutine(CharaTransparencyChange(ADVCharaID, a, Sec, CurveType));
    }
    private void CharaTransparencyAll(uint Alpha, float Sec, int CurveType)
    {
        float a = Alpha / 255f;
        foreach (string ADVCharaID in CharasExist.Keys)
        {
            if (charaCoroutinesDict[ADVCharaID]["transparency"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["transparency"]); }
            charaCoroutinesDict[ADVCharaID]["transparency"] = StartCoroutine(CharaTransparencyChange(ADVCharaID, a, Sec, CurveType));
        }
    }
    private void CharaTransparencyResetAll()
    {
        foreach (string ADVCharaID in CharasExist.Keys)
        {
            if (charaCoroutinesDict[ADVCharaID]["transparency"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["transparency"]); }
            charaCoroutinesDict[ADVCharaID]["transparency"] = StartCoroutine(CharaTransparencyChange(ADVCharaID, 1, 0, 0));
        }
    }
    private void CharaRotate(string ADVCharaID, int CharaAnchor, float Angle, float Sec, int CurveType)
    {
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        advcharacterlist_Params param = GetCharaParams(ADVCharaID);
        advclist_Params_Data Pose = GetCharaParamsPose(ADVCharaID);
        Texture2D texture;
        int FaceReferenceImageType = GetCharaParamsPoseFaceRefernceImageType(ADVCharaID);
        if (FaceReferenceImageType == 0)
        {
            texture = webTexture[param.m_ResourceBaseName + "_StandPic_" + Pose.m_PoseID];
        }
        else { texture = webTexture[param.m_ResourceBaseName + "_Face_" + Pose.m_PoseID + "_" + charaFaceID[charaProperties.FaceID]]; }
        float PivotX = 0.5f;
        float PivotY = 0.5f;
        switch (CharaAnchor)
        {
            case 0:
                PivotY = (texture.height * (1 - Pose.m_FaceReferenceImageType * Pose.m_FacePivotY) + Pose.m_OffsetY) / 2f / texture.height;
                break;
            case 1:
                PivotX = Pose.m_FaceX / texture.width;
                PivotY = Pose.m_FaceY / texture.height;
                break;
            case 2:
                PivotX = (texture.width / 2 + Pose.m_FootOffsetX) / texture.width;
                PivotY = (texture.height * (1 - Pose.m_FaceReferenceImageType * Pose.m_FacePivotY) + Pose.m_OffsetY + Pose.m_FootOffsetY) / texture.height;
                break;
            default:
                break;
        }
        if (charaCoroutinesDict[ADVCharaID]["rotate"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["rotate"]); }
        charaCoroutinesDict[ADVCharaID]["rotate"] = StartCoroutine(CharaRotateChange(ADVCharaID, PivotX, PivotY, Angle, Sec, CurveType));
    }
    private void CharaRotate(string ADVCharaID, float PivotX, float PivotY, float Angle, float Sec, int CurveType)
    {
        if (charaCoroutinesDict[ADVCharaID]["rotate"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["rotate"]); }
        charaCoroutinesDict[ADVCharaID]["rotate"] = StartCoroutine(CharaRotateChange(ADVCharaID, PivotX, PivotY, Angle, Sec, CurveType));
    }
    private void CharaRotateReset(string ADVCharaID, float Sec)
    {
        if (charaCoroutinesDict[ADVCharaID]["rotate"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["rotate"]); }
        charaCoroutinesDict[ADVCharaID]["rotate"] = StartCoroutine(CharaRotateResetChange(ADVCharaID, Sec));
    }
    private void WaitCharaRotate(string ADVCharaID)
    {
        StartCoroutine(WaitForCharaRotate(ADVCharaID));
    }
    private void WaitCharaRotate()
    {
        StartCoroutine(WaitForCharaRotate());
    }
    private void CharaAlignment(float Sec, int CurveType)
    {
        List<float> Xs = new List<float>();
        Dictionary<float, string> XToChara = new Dictionary<float, string>();
        foreach (string ADVCharaID in CharasExist.Keys)
        {
            Xs.Add(charaPropertiesDict[ADVCharaID].Position.x);
            XToChara.Add(charaPropertiesDict[ADVCharaID].Position.x, ADVCharaID);
        }
        Xs.Sort();
        if (Xs.Count == 2)
        {
            for (int i = 0; i < 2; i++)
            {
                StartCoroutine(CharaMoveTo(XToChara[Xs[i]], 444f * (i - 0.5f), 0, Sec, CurveType));
            }
        }
        else if (Xs.Count == 3)
        {
            for (int i = 0; i < 3; i++)
            {
                StartCoroutine(CharaMoveTo(XToChara[Xs[i]], 333f * (i - 1f), 0, Sec, CurveType));
            }
        }
    }
    private void CharaSwap(string ADVCharaID1, string ADVCharaID2, float Sec, int CurveType)
    {
        CharaProperties charaProperties1 = charaPropertiesDict[ADVCharaID1];
        CharaProperties charaProperties2 = charaPropertiesDict[ADVCharaID2];
        StartCoroutine(CharaMoveTo(ADVCharaID1, charaProperties2.Position[0], charaProperties2.Position[1], Sec, CurveType));
        StartCoroutine(CharaMoveTo(ADVCharaID2, charaProperties1.Position[0], charaProperties1.Position[1], Sec, CurveType));
    }
    private void SetTarget(string ADVCharaID, string ADVCharaID2, string ADVCharaID3, string ADVCharaID4, string ADVCharaID5)
    {
        CharaTargets[0] = ADVCharaID;
        CharaTargets[1] = ADVCharaID2;
        CharaTargets[2] = ADVCharaID3;
        CharaTargets[3] = ADVCharaID4;
        CharaTargets[4] = ADVCharaID5;
    }
    private void CharaInTarget(int StartSide, float Sec, int CurveType, float XOffset)
    {
        List<float> Xs = new List<float>();
        for (int i = 0; i < 5; i++)
        {
            if (GetCharaParams(CharaTargets[i]) != null)
            {
                Xs.Add(charaShotPx[i] + XOffset);
            }
        }
        float Offset;
        if (StartSide == 0) { Offset = charaShotPx[-1] - Xs.Max(); } else { Offset = charaShotPx[-2] - Xs.Min(); }
        for (int i = 0; i < 5; i++)
        {
            if (GetCharaParams(CharaTargets[i]) != null)
            {
                CreateStandpic(CharaTargets[i]);
                CharaSetPosition(CharaTargets[i], Offset + charaShotPx[i], 0);
                charaPropertiesDict[CharaTargets[i]].Fade = 1f;
                isUpdateCharaFade.Add(CharaTargets[i]);
                StartCoroutine(CharaMoveTo(CharaTargets[i], charaShotPx[i] + XOffset, 0, Sec, CurveType));
            }
        }
    }
    private void CharaOutTarget(int EndSide, float Sec, int CurveType)
    {
        List<float> Xs = new List<float>();
        for (int i = 0; i < 5; i++)
        {
            if (GetCharaParams(CharaTargets[i]) != null)
            {
                Xs.Add(charaShotPx[i]);
            }
        }
        float Offset;
        if (EndSide == 0) { Offset = charaShotPx[-1] - Xs.Max(); } else { Offset = charaShotPx[-2] - Xs.Min(); }
        for (int i = 0; i < 5; i++)
        {
            if (GetCharaParams(CharaTargets[i]) != null)
            {
                Coroutine MoveCoroutine = StartCoroutine(CharaMoveTo(CharaTargets[i], Offset + charaShotPx[i], 0, Sec, CurveType));
                if (charaCoroutinesDict[CharaTargets[i]]["destroy"] != null) { StopCoroutine(charaCoroutinesDict[CharaTargets[i]]["destroy"]); }
                charaCoroutinesDict[CharaTargets[i]]["destroy"] = StartCoroutine(DestroyAfterAnimation(CharaTargets[i], new List<Coroutine> { MoveCoroutine }));
            }
        }
    }
    private void SpriteSet(uint ID, string FileNameWithoutExt)
    {
        GameObject sprite;
        if (spriteCoroutinesDict.ContainsKey(ID))
        {
            sprite = FindCached("Sprite_" + ID.ToString());
            Texture2D texture = new Texture2D(0, 0);
            if (webTexture.ContainsKey(FileNameWithoutExt))
            {
                texture = webTexture[FileNameWithoutExt];
            }
            else
            {
                //Debug.LogError("Texture Not Found: "+FileNameWithoutExt);
            }
            texture.wrapMode = TextureWrapMode.Clamp;
            Sprite sprite1 = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 1, 0, SpriteMeshType.FullRect);
            SpriteRenderer spriteRenderer = sprite.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite1;
            foreach (Coroutine coroutine in spriteCoroutinesDict[ID].Values)
            {
                if (coroutine == null) { continue; }
                StopCoroutine(coroutine);
            }
            SpriteScaling.RemoveAll(item => item == ID);
            SpritePosing.RemoveAll(item => item == ID);
            SpriteFading.RemoveAll(item => item == ID);
            SpriteColoring.RemoveAll(item => item == ID);
        }
        else
        {
            sprite = new GameObject("Sprite_" + ID);
            CacheGameObject("Sprite_" + ID, sprite);
            Texture2D texture = new Texture2D(0, 0);
            if (webTexture.ContainsKey(FileNameWithoutExt))
            {
                texture = webTexture[FileNameWithoutExt];
            }
            else
            {
                //Debug.LogError("Texture Not Found: "+FileNameWithoutExt);
            }
            texture.wrapMode = TextureWrapMode.Clamp;
            Sprite sprite1 = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 1);
            SpriteRenderer spriteRenderer = sprite.AddComponent<SpriteRenderer>();
            spriteRenderer.material = new Material(Shader.Find("CustomShader_COMMON"));
            spriteRenderer.sprite = sprite1;
            spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
            spriteRenderer.sortingOrder = -700 + (int)ID;
            sprite.AddComponent<RectTransform>();
            sprite.transform.SetParent(canvas.transform);
            sprite.AddComponent<SpriteProperties>();
            spriteCoroutinesDict.Add(ID, new Dictionary<string, Coroutine> { { "scale", null }, { "pos", null }, { "color", null }, { "fade", null } });
            sprite.layer = LayerMask.NameToLayer("Sprite");
        }
        SpriteProperties spriteProperties = sprite.GetComponent<SpriteProperties>();
        spriteProperties.ID = ID;
        spriteProperties.pos = new Vector2(0f, 0f);
        spriteProperties.scale = new Vector2(0f, 0f);
        spriteProperties.color = new Color(1f, 1f, 1f, 1f);
        spriteProperties.fade = 0f;
    }
    private void SpriteScale(uint ID, float X, float Y, float Sec)
    {
        FindCached("Sprite_" + ID.ToString()).GetComponent<SpriteProperties>().scale = new Vector2(X, Y);
        if (spriteCoroutinesDict[ID]["scale"] != null) { StopCoroutine(spriteCoroutinesDict[ID]["scale"]); }
        spriteCoroutinesDict[ID]["scale"] = StartCoroutine(SpriteScaleChange(ID, X, Y, Sec));
    }
    private void SpritePos(uint ID, float X, float Y, float Sec)
    {
        FindCached("Sprite_" + ID.ToString()).GetComponent<SpriteProperties>().pos = new Vector2(X, Y);
        if (spriteCoroutinesDict[ID]["pos"] != null) { StopCoroutine(spriteCoroutinesDict[ID]["pos"]); }
        spriteCoroutinesDict[ID]["pos"] = StartCoroutine(SpritePosChange(ID, X, Y, Sec));
    }
    private void SpriteVisible(uint ID, uint VisibleFlg)
    {
        GameObject sprite = FindCached("Sprite_" + ID.ToString());
        SpriteProperties spriteProperties = sprite.GetComponent<SpriteProperties>();
        spriteProperties.fade = VisibleFlg == 1 ? 1f : 0f;
        Color color = spriteProperties.color;
        sprite.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, color.a * spriteProperties.fade);
    }
    private void SpriteColor(uint ID, string RGBA, float Sec)
    {
        ColorUtility.TryParseHtmlString(RGBA, out Color color);
        FindCached("Sprite_" + ID.ToString()).GetComponent<SpriteProperties>().color = color;
        if (spriteCoroutinesDict[ID]["color"] != null) { StopCoroutine(spriteCoroutinesDict[ID]["color"]); }
        spriteCoroutinesDict[ID]["color"] = StartCoroutine(SpriteColorChange(ID, color, Sec));
    }
    private void SpriteFadeIn(uint ID, float Sec)
    {
        if (spriteCoroutinesDict[ID]["fade"] != null) { StopCoroutine(spriteCoroutinesDict[ID]["fade"]); }
        spriteCoroutinesDict[ID]["fade"] = StartCoroutine(SpriteFade(ID, Sec, 1f));
    }
    private void SpriteFadeOut(uint ID, float Sec)
    {
        if (spriteCoroutinesDict[ID]["fade"] != null) { StopCoroutine(spriteCoroutinesDict[ID]["fade"]); }
        spriteCoroutinesDict[ID]["fade"] = StartCoroutine(SpriteFade(ID, Sec, 0f));
    }
    private void WaitSpriteScale(uint ID)
    {
        StartCoroutine(WaitForSpriteScale(ID));
    }
    private void WaitSpritePos(uint ID)
    {
        StartCoroutine(WaitForSpritePos(ID));
    }
    private void WaitSpritePos()
    {
        StartCoroutine(WaitForSpritePos());
    }
    private void WaitSpriteFade(uint ID)
    {
        StartCoroutine(WaitForSpriteFade(ID));
    }
    private void WaitSpriteFade()
    {
        StartCoroutine(WaitForSpriteFade());
    }
    private void WaitSpriteColor(uint ID)
    {
        StartCoroutine(WaitForSpriteColor(ID));
    }
    private void WaitSpriteColor()
    {
        StartCoroutine(WaitForSpriteColor());
    }
    private void PlayCaption(uint textID)
    {
        StartCoroutine(Caption(textID));
    }
    private void SetCaptionBGSprite(string fileName, float width, float height)
    {
        if (fileName != "無し")
        {
            CaptionBGSprite = webTexture[fileName].EncodeToPNG();
        }
        else { CaptionBGSprite = new byte[0]; }
        CaptionBGSpriteWH = new float[2] { width, height };
    }
    private void SetCaptionBGStart(float posX, float posY, float sclX, float sclY, string rgba)
    {
        CaptionPosScl["BG"][0, 0] = posX;
        CaptionPosScl["BG"][0, 1] = posY;
        CaptionPosScl["BG"][0, 2] = sclX;
        CaptionPosScl["BG"][0, 3] = sclY;
        CaptionRGBA["BG"][0] = rgba;
    }
    private void SetCaptionBGIdle(float posX, float posY, float sclX, float sclY, string rgba)
    {
        CaptionPosScl["BG"][1, 0] = posX;
        CaptionPosScl["BG"][1, 1] = posY;
        CaptionPosScl["BG"][1, 2] = sclX;
        CaptionPosScl["BG"][1, 3] = sclY;
        CaptionRGBA["BG"][1] = rgba;
    }
    private void SetCaptionBGEnd(float posX, float posY, float sclX, float sclY, string rgba)
    {
        CaptionPosScl["BG"][2, 0] = posX;
        CaptionPosScl["BG"][2, 1] = posY;
        CaptionPosScl["BG"][2, 2] = sclX;
        CaptionPosScl["BG"][2, 3] = sclY;
        CaptionRGBA["BG"][2] = rgba;
    }
    private void SetCaptionBGEaseIn(float sec, float delay, int curveType)
    {
        CaptionSecDelay["BG"][0, 0] = sec;
        CaptionSecDelay["BG"][0, 1] = delay;
        CaptionCurveType["BG"][0] = curveType;
    }
    private void SetCaptionBGEaseOut(float sec, float delay, int curveType)
    {
        CaptionSecDelay["BG"][1, 0] = sec;
        CaptionSecDelay["BG"][1, 1] = delay;
        CaptionCurveType["BG"][1] = curveType;
    }
    private void SetCaptionTextStart(float posX, float posY, float sclX, float sclY, string rgba)
    {
        CaptionPosScl["Text"][0, 0] = posX;
        CaptionPosScl["Text"][0, 1] = posY;
        CaptionPosScl["Text"][0, 2] = sclX;
        CaptionPosScl["Text"][0, 3] = sclY;
        CaptionRGBA["Text"][0] = rgba;
    }
    private void SetCaptionTextIdle(float posX, float posY, float sclX, float sclY, string rgba)
    {
        CaptionPosScl["Text"][1, 0] = posX;
        CaptionPosScl["Text"][1, 1] = posY;
        CaptionPosScl["Text"][1, 2] = sclX;
        CaptionPosScl["Text"][1, 3] = sclY;
        CaptionRGBA["Text"][1] = rgba;
    }
    private void SetCaptionTextEnd(float posX, float posY, float sclX, float sclY, string rgba)
    {
        CaptionPosScl["Text"][2, 0] = posX;
        CaptionPosScl["Text"][2, 1] = posY;
        CaptionPosScl["Text"][2, 2] = sclX;
        CaptionPosScl["Text"][2, 3] = sclY;
        CaptionRGBA["Text"][2] = rgba;
    }
    private void SetCaptionTextEaseIn(float sec, float delay, int curveType)
    {
        CaptionSecDelay["Text"][0, 0] = sec;
        CaptionSecDelay["Text"][0, 1] = delay;
        CaptionCurveType["Text"][0] = curveType;
    }
    private void SetCaptionTextEaseOut(float sec, float delay, int curveType)
    {
        CaptionSecDelay["Text"][1, 0] = sec;
        CaptionSecDelay["Text"][1, 1] = delay;
        CaptionCurveType["Text"][1] = curveType;
    }
    private void SetCaptionDefault()
    {
        CaptionBGSprite = new byte[0];
        CaptionBGSpriteWH = new float[2] { 0f, 0f };
        CaptionPosScl = new Dictionary<string, float[,]> { { "BG", new float[3, 4] { { 0f, 0f, 1f, 1f }, { 0f, 0f, 1f, 1f }, { 0f, 0f, 1f, 1f } } }, { "Text", new float[3, 4] { { -80f, 0f, 1f, 1f }, { 0f, 0f, 1f, 1f }, { 80f, 0f, 1f, 1f } } } };
        CaptionRGBA = new Dictionary<string, string[]> { { "BG", new string[3] { "#FFFFFF00", "#FFFFFFFF", "#FFFFFF00" } }, { "Text", new string[3] { "#FFFFFF00", "#FFFFFFFF", "#FFFFFF00" } } };
        CaptionSecDelay = new Dictionary<string, float[,]> { { "BG", new float[2, 2] { { 0.2f, 0 }, { 0.2f, 0f } } }, { "Text", new float[2, 2] { { 0.2f, 0.2f }, { 0.2f, 0f } } } };
        CaptionCurveType = new Dictionary<string, int[]> { { "BG", new int[2] { 0, 0 } }, { "Text", new int[2] { 2, 1 } } };
    }
    private void CharaHighlightTalker(string ADVCharaID)
    {
        talkingChara = new List<string> { ADVCharaID };
    }
    private void CharaEmotion(string ADVCharaID, string EmotionID, int EmoPosition)
    {
        StartCoroutine(PlayEmotion(ADVCharaID, EmotionID, EmoPosition));
    }
    private void WaitEmotion(string ADVCharaID, string EmotionID)
    {
        StartCoroutine(WaitForEmotion(ADVCharaID, EmotionID));
    }
    private void EmotionEnd(string ADVCharaID, string EmotionID)
    {
        List<string[]> emoremoves = new List<string[]>();
        foreach (string[] emo0 in Emotioning.Keys)
        {
            if (emo0[0] == ADVCharaID && emo0[1] == EmotionID)
            {
                Emotioning[emo0].SetActive(false);
                emoremoves.Add(emo0);
            }
        }
        foreach (string[] emoremove in emoremoves)
        {
            Destroy(Emotioning[emoremove]);
            Emotioning.Remove(emoremove);
        }
    }
    private void CharaTalk(uint TextID, int FaceID, string EmotionID)
    {
        advscripttext_Params param = advScriptText.m_Params.First(param => param.m_ID == TextID);
        string charaName = param.m_charaName.IndexOf('$') == -1 ? param.m_charaName : param.m_charaName[(param.m_charaName.IndexOf('$') + 1)..];
        autoWait = new List<Coroutine>();
        if (charaName != "")
        {
            string[] charas = charaName.Split("・");
            if (GetCharaParams(charaName) != null)
            {
                advcharacterlist_Params charaParams = GetCharaParams(charaName);
                if (charaParams == null)
                {
                isUpdateHighlight = true;
                    isUpdatePriority = true;
                    autoWait.Add(StartCoroutine(Talk(param, false)));
                }
                else
                {
                    if (FaceID != -1)
                    {
                        CharaFace(charaName, FaceID);
                    }
                    if (EmotionID != "")
                    {
                        StartCoroutine(PlayEmotion(charaName, EmotionID, 0));
                    }
                    talkingChara = new List<string> { charaName };
                    isUpdateHighlight = true;
                    isUpdatePriority = true;
                    autoWait.Add(StartCoroutine(Talk(param, false)));
                    if (param.m_voiceLabel != "")
                    {
                        List<string> voicePaths = new List<string>();
                        string voiceName = charaName + "_" + param.m_voiceLabel;
                        string voicePathBase = "";
                        if (charaParams.m_CueSheet != "")
                        {
                            voicePathBase = charaParams.m_CueSheet + @"\" + param.m_voiceLabel + "_";
                        }
                        else if (charaParams.m_NamedType != -1)
                        {
                            string charaResourceName = advCharaVoiceLabel.m_Params.First(param => param.m_NamedType == charaParams.m_NamedType).m_VoiceLabel;
                            voicePathBase = charaResourceName + @"\" + param.m_voiceLabel + "_";
                        }
                        for (int i = 0; i < 100; i++)
                        {
                            if (webAudio.ContainsKey(voicePathBase + i.ToString("D2")))
                            {
                                voicePaths.Add(i.ToString("D2"));
                            }
                            else { break; }
                        }
                        if (voicePaths.Count > 0)
                        {
                            System.Random random = new System.Random();
                            string voicePath = voicePathBase + voicePaths[random.Next(voicePaths.Count)];
                            GameObject voice = new GameObject(voiceName);
                            voice.transform.SetParent(Audios.transform);
                            AudioSource audioSource = voice.AddComponent<AudioSource>();
                            voice.transform.position = new Vector3(-1000f, 0f, 0f);
                            audioSource.clip = webAudio[voicePath];
                            autoWait.Add(StartCoroutine(PlayTalkVoice(voice)));
                        }
                    }
                }
            }
            else if (charas.Length > 1)
            {
                talkingChara = new List<string>();
                foreach (string charaname in charas)
                {
                    KeyValuePair<string, string> chara1 = CharasExist.FirstOrDefault(item => item.Value == charaname);
                    if (chara1.Key != null)
                    {
                        talkingChara.Add(chara1.Key);
                    }
                }
                isUpdateHighlight = true;
                isUpdatePriority = true;
                autoWait.Add(StartCoroutine(Talk(param, false)));
                if (param.m_voiceLabel != "")
                {
                    advcharacterlist_Params charaParams = GetCharaParams(CharasExist.FirstOrDefault(item => item.Value == charas[0]).Key);
                    List<string> voicePaths = new List<string>();
                    string voiceName = charaName + "_" + param.m_voiceLabel;
                    string voicePathBase = "";
                    if (charaParams.m_CueSheet != "")
                    {
                        voicePathBase = charaParams.m_CueSheet + @"\" + param.m_voiceLabel + "_";
                    }
                    else if (charaParams.m_NamedType != -1)
                    {
                        string charaResourceName = advCharaVoiceLabel.m_Params.First(param => param.m_NamedType == charaParams.m_NamedType).m_VoiceLabel;
                        voicePathBase = charaResourceName + @"\" + param.m_voiceLabel + "_";
                    }
                    for (int i = 0; i < 100; i++)
                    {
                        if (webAudio.ContainsKey(voicePathBase + i.ToString("D2")))
                        {
                            voicePaths.Add(i.ToString("D2"));
                        }
                        else { break; }
                    }
                    if (voicePaths.Count > 0)
                    {
                        System.Random random = new System.Random();
                        string voicePath = voicePathBase + voicePaths[random.Next(voicePaths.Count)];
                        GameObject voice = new GameObject(voiceName);
                        voice.transform.SetParent(Audios.transform);
                        AudioSource audioSource = voice.AddComponent<AudioSource>();
                        voice.transform.position = new Vector3(-1000f, 0f, 0f);
                        audioSource.clip = webAudio[voicePath];
                        autoWait.Add(StartCoroutine(PlayTalkVoice(voice)));
                    }
                }
            }
            else
            {
                talkingChara = new List<string>();
                isUpdateHighlight = true;
                isUpdatePriority = true;
                autoWait.Add(StartCoroutine(Talk(param, false)));
            }
        }
        else
        {
            talkingChara = new List<string> { };
            isUpdateHighlight = true;
            autoWait.Add(StartCoroutine(Talk(param, true)));
        }
        autoSkipCoroutine.Add(StartCoroutine(AutoSkip(1f)));
    }
    private void CharaTalkFullVoice(uint TextID, int FaceID, string EmotionID)
    {
        advscripttext_Params param = advScriptText.m_Params.First(param => param.m_ID == TextID);
        string charaName = param.m_charaName.IndexOf('$') == -1 ? param.m_charaName : param.m_charaName[(param.m_charaName.IndexOf('$') + 1)..];
        autoWait = new List<Coroutine>();
        if (charaName != "")
        {
            if (FaceID != -1)
            {
                CharaFace(charaName, FaceID);
            }
            if (EmotionID != "")
            {
                StartCoroutine(PlayEmotion(charaName, EmotionID, 0));
            }
            talkingChara = new List<string> { charaName };
            isUpdateHighlight = true;
            isUpdatePriority = true;
            autoWait.Add(StartCoroutine(Talk(param, false)));
            if (param.m_voiceLabel != "")
            {
                string voicePath = advList.m_Params.First(param => param.m_AdvID == ADVID).m_CueSheet + "_" + param.m_voiceLabel;
                GameObject voice = new GameObject(param.m_voiceLabel);
                voice.transform.SetParent(Audios.transform);
                AudioSource audioSource = voice.AddComponent<AudioSource>();
                voice.transform.position = new Vector3(-1000f, 0f, 0f);
                audioSource.clip = webAudio[voicePath];
                autoWait.Add(StartCoroutine(PlayTalkVoice(voice)));
            }
        }
        else
        {
            talkingChara = new List<string> { };
            isUpdateHighlight = true;
            autoWait.Add(StartCoroutine(Talk(param, true)));
        }
        autoSkipCoroutine.Add(StartCoroutine(AutoSkip(1f)));
    }
    private void CloseTalk()
    {
        //isUpdateHighlight=true;
        if (CanvasMoveCoroutine != null) { StopCoroutine(CanvasMoveCoroutine); }
        CanvasMoveCoroutine = StartCoroutine(ToggleCanvas(false));
        textCanvasVisible = false;
    }
    private void BGPointScale(uint ID, float Scale, float Sec, float X, float Y, int CurveType)
    {
        if (bgCoroutinesDict[ID]["scale"] != null) { StopCoroutine(bgCoroutinesDict[ID]["scale"]); }
        bgCoroutinesDict[ID]["scale"] = StartCoroutine(BGScaleChange(ID, Scale, Sec, CurveType));
        if (bgCoroutinesDict[ID]["scroll"] != null) { StopCoroutine(bgCoroutinesDict[ID]["scroll"]); }
        bgCoroutinesDict[ID]["scroll"] = StartCoroutine(BGScrollChange(ID, Sec, X * Scale, Y * Scale, CurveType));
    }
    private void BGColor(uint ID, string StartColor, string EndColor, float Sec, int CurveType)
    {
        ColorUtility.TryParseHtmlString(StartColor, out Color startcolor);
        ColorUtility.TryParseHtmlString(EndColor, out Color endcolor);
        GameObject bg = FindCached("bg_" + ID.ToString());
        StartCoroutine(BGColorChange(bg, startcolor, endcolor, Sec, CurveType));
    }
    private void SetBGAnchor(uint ID, int Anchor)
    {
        GameObject bg = FindCached("bg_" + ID.ToString());
        RectTransform rectTransform = bg.GetComponent<RectTransform>();
        BGProperties bgProperties = bg.GetComponent<BGProperties>();
        float anchorOld = rectTransform.anchorMax.y;
        float anchorNew = 0.5f;
        switch (Anchor)
        {
            case 0:
                anchorNew = 0.5f;
                break;
            case 1:
                anchorNew = 1f;
                break;
            case 2:
                anchorNew = 0f;
                break;
            default:
                break;
        }
        rectTransform.anchorMax = new Vector2(0.5f, anchorNew);
        rectTransform.anchorMin = new Vector2(0.5f, anchorNew);
        bgProperties.Position.y += (anchorOld - anchorNew) * 750f;
        isUpdateBGPosition = true;
    }
    private void BGScroll(uint ID, float X, float Y, float Sec, int CurveType)
    {
        if (bgCoroutinesDict[ID]["scroll"] != null) { StopCoroutine(bgCoroutinesDict[ID]["scroll"]); }
        bgCoroutinesDict[ID]["scroll"] = StartCoroutine(BGScrollChange(ID, Sec, X, Y, CurveType));
    }
    private void BGScale(uint ID, float Scale, float Sec, int CurveType)
    {
        if (bgCoroutinesDict[ID]["scale"] != null) { StopCoroutine(bgCoroutinesDict[ID]["scale"]); }
        bgCoroutinesDict[ID]["scale"] = StartCoroutine(BGScaleChange(ID, Scale, Sec, CurveType));
    }
    private void BGScrollReset(uint ID, float Sec, int CurveType)
    {
        if (bgCoroutinesDict[ID]["scale"] != null) { StopCoroutine(bgCoroutinesDict[ID]["scale"]); }
        bgCoroutinesDict[ID]["scale"] = StartCoroutine(BGScaleChange(ID, 1, Sec, CurveType));
        if (bgCoroutinesDict[ID]["scroll"] != null) { StopCoroutine(bgCoroutinesDict[ID]["scroll"]); }
        bgCoroutinesDict[ID]["scroll"] = StartCoroutine(BGScrollChange(ID, Sec, 0, 0, CurveType));
    }
    private void Shake(int ShakeType, float Time)
    {
        StartCoroutine(ShakeCanvas(ShakeType, Time));
    }
    private void ShakeBG(int ShakeType, float Time)
    {
        foreach (uint bg in bgCoroutinesDict.Keys)
        {
            StartCoroutine(ShakeBGCoroutine("bg_" + bg.ToString(), ShakeType, Time));
        }
    }
    private void ShakeChara(int ShakeType, float Time, string ADVCharaID)
    {
        if (charaCoroutinesDict[ADVCharaID]["shake"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["shake"]); }
        charaCoroutinesDict[ADVCharaID]["shake"] = StartCoroutine(ShakeCharaCoroutine(ADVCharaID, ShakeType, Time));
    }
    private void ShakeChara(int ShakeType, float Time)
    {
        foreach (string ADVCharaID in CharasExist.Keys)
        {
            if (charaCoroutinesDict[ADVCharaID]["shake"] != null) { StopCoroutine(charaCoroutinesDict[ADVCharaID]["shake"]); }
            charaCoroutinesDict[ADVCharaID]["shake"] = StartCoroutine(ShakeCharaCoroutine(ADVCharaID, ShakeType, Time));
        }
    }
    private void StopShake()
    {
        StartCoroutine(StoppingShake());
    }
    private void Effect(string effectID, int StandPosition, float X, float Y, float Rotate)
    {
        CreateEffect(effectID, StandPosition, X, Y, Rotate, false, false, 750f);
    }
    private void EffectChara(string effectID, string ADVCharaID, int CharaAnchor, float X, float Y, float Rotate)
    {
        CreateEffectChara(effectID, ADVCharaID, CharaAnchor, X, Y, Rotate, false, false, 750f);
    }
    private void EffectScreen(string effectID, int ScreenAnchor, float X, float Y, float Rotate)
    {
        CreateEffectScreen(effectID, ScreenAnchor, X, Y, Rotate, false, false, 140.625f);
    }
    private void EffectLoop(string effectID, int StandPosition, float X, float Y, float Rotate)
    {
        CreateEffect(effectID, StandPosition, X, Y, Rotate, false, true, 750f);
    }
    private void EffectCharaLoop(string effectID, string ADVCharaID, int CharaAnchor, float X, float Y, float Rotate)
    {
        CreateEffectChara(effectID, ADVCharaID, CharaAnchor, X, Y, Rotate, false, true, 750f);
    }
    private void EffectScreenLoop(string effectID, int ScreenAnchor, float X, float Y, float Rotate)
    {
        CreateEffectScreen(effectID, ScreenAnchor, X, Y, Rotate, false, true, 140.625f);
    }
    private void EffectLoopTarget(string effectID, string afterEffectID, int StandPosition, float X, float Y)
    {
        StartCoroutine(CreateEffectLoopTarget(effectID, afterEffectID, StandPosition, X, Y, false));
    }
    private void EffectCharaLoopTarget(string effectID, string afterEffectID, string ADVCharaID, int CharaAnchor, float X, float Y)
    {
        StartCoroutine(CreateEffectCharaLoopTarget(effectID, afterEffectID, ADVCharaID, CharaAnchor, X, Y, false));
    }
    private void EffectScreenLoopTarget(string effectID, string afterEffectID, int ScreenAnchor, float X, float Y)
    {
        StartCoroutine(CreateEffectScreenLoopTarget(effectID, afterEffectID, ScreenAnchor, X, Y, false));
    }
    private void EffectLoopTargetEnd(string effectID)
    {
        if (Effecting.ContainsKey(effectID))
        {
            foreach (GameObject ef in Effecting[effectID])
            {
                Destroy(ef);
            }
            Effecting.Remove(effectID);
        }
    }
    private void Effect_CharaBehind(string effectID, int StandPosition, float X, float Y, float Rotate)
    {
        CreateEffect(effectID, StandPosition, X, Y, Rotate, true, false, 750f);
    }
    private void EffectChara_CharaBehind(string effectID, string ADVCharaID, int CharaAnchor, float X, float Y, float Rotate)
    {
        CreateEffectChara(effectID, ADVCharaID, CharaAnchor, X, Y, Rotate, true, false, 750f);
    }
    private void EffectScreen_CharaBehind(string effectID, int ScreenAnchor, float X, float Y, float Rotate)
    {
        CreateEffectScreen(effectID, ScreenAnchor, X, Y, Rotate, true, false, 140.625f);
    }
    private void EffectLoop_CharaBehind(string effectID, int StandPosition, float X, float Y, float Rotate)
    {
        CreateEffect(effectID, StandPosition, X, Y, Rotate, true, true, 750f);
    }
    private void EffectCharaLoop_CharaBehind(string effectID, string ADVCharaID, int CharaAnchor, float X, float Y, float Rotate)
    {
        CreateEffectChara(effectID, ADVCharaID, CharaAnchor, X, Y, Rotate, true, true, 750f);
    }
    private void EffectScreenLoop_CharaBehind(string effectID, int ScreenAnchor, float X, float Y, float Rotate)
    {
        CreateEffectScreen(effectID, ScreenAnchor, X, Y, Rotate, true, true, 140.625f);
    }
    private void EffectLoopTarget_CharaBehind(string effectID, string afterEffectID, int StandPosition, float X, float Y)
    {
        StartCoroutine(CreateEffectLoopTarget(effectID, afterEffectID, StandPosition, X, Y, true));
    }
    private void EffectCharaLoopTarget_CharaBehind(string effectID, string afterEffectID, string ADVCharaID, int CharaAnchor, float X, float Y)
    {
        StartCoroutine(CreateEffectCharaLoopTarget(effectID, afterEffectID, ADVCharaID, CharaAnchor, X, Y, true));
    }
    private void EffectScreenLoopTarget_CharaBehind(string effectID, string afterEffectID, int ScreenAnchor, float X, float Y)
    {
        StartCoroutine(CreateEffectScreenLoopTarget(effectID, afterEffectID, ScreenAnchor, X, Y, true));
    }
    private void EffectEnd(string effectID)
    {
        if (Effecting.ContainsKey(effectID))
        {
            foreach (GameObject ef in Effecting[effectID])
            {
                EffectEnding.Add(ef);
            }
            Effecting.Remove(effectID);
        }
    }
    private void WaitEffect(string effectID)
    {
        StartCoroutine(WaitForEffect(effectID));
    }
    private void EffectMuteSE()
    {
        EffectSEMuted = true;
    }
    private void EffectMuteSEReset()
    {
        EffectSEMuted = false;
    }
    private void PresetEffectLoop(string stEffectID, string lpEffectID, string EdEffectID, sbyte IgnoreParticle)
    {
        EffectPreset = new string[3] { stEffectID, lpEffectID, EdEffectID };
    }
    private void EffectLoopWithPreset(int StandPosition, float X, float Y, float Rotate)
    {
        StartCoroutine(CreateEffectLoopWithPreset(StandPosition, X, Y, Rotate));
    }
    private void EffectCharaLoopWithPreset(string ADVCharaID, int CharaAnchor, float X, float Y, float Rotate)
    {
        StartCoroutine(CreateEffectCharaLoopWithPreset(ADVCharaID, CharaAnchor, X, Y, Rotate));
    }
    private void EffectScreenLoopWithPreset(int Anchor, float X, float Y, float Rotate)
    {
        StartCoroutine(CreateEffectScreenLoopWithPreset(Anchor, X, Y, Rotate));
    }
    private void SetHDRFactor(string ADVCharaID, float Value, float Sec)
    {
        StartCoroutine(SetHDRFactorChara(ADVCharaID, Value, Sec));
    }
    private void SetPP_ColorBlendColor(uint R, uint G, uint B)
    {
        renderSpriteRenderer.material.SetColor(_ColorBlend, new Color(R / 255f, G / 255f, B / 255f, 1f));
    }
    private void SetPP_ColorBlendLevel(float Value, float Sec)
    {
        StartCoroutine(ColorBlendLevelChange(Value, Sec));
    }
    private void Enable_PP_ColorBlend(uint Enable)
    {
        renderSpriteRenderer.material.SetFloat(_EnableColorBlend, Enable);
    }
    private void SetDistorsionLevel_BG(float Value, float Sec)
    {
        if (DistortionLevelChangeCoroutine != null) { StopCoroutine(DistortionLevelChangeCoroutine); }
        DistortionLevelChangeCoroutine = StartCoroutine(DistorsionLevel_BGChange(Value, Sec));
    }
    private void EnableDistorsion_BG(uint Enable)
    {
        bgPrimObj.GetComponent<MeshRenderer>().material.SetFloat(_EnableDistortion, Enable);
    }
    private void WarpPrepare(string ADVCharaID, float Sec)
    {
        GameObject chara = FindCached(ADVCharaID + "_RT");
        chara.GetComponent<MeshRenderer>().material.SetFloat(_Warp, 1);
        StartCoroutine(PrepareWarp(ADVCharaID, Sec));
    }
    private void WarpPrepareWait()
    {
        StartCoroutine(WaitForWarpPrepare());
    }
    private void WarpStart(float Sec)
    {
        foreach (string ADVCharaID in warpPrepared)
        {
            StartCoroutine(Warp(ADVCharaID, Sec));
        }
    }
    private void WarpWait()
    {
        StartCoroutine(WaitForWarp());
    }
    private void PlayBGM(string BGMCueName, float FadeInSec)
    {
        GameObject BGM = new GameObject(BGMCueName);
        BGM.transform.SetParent(Audios.transform);
        AudioSource audioSource = BGM.AddComponent<AudioSource>();
        audioSource.loop = true;
        BGM.transform.position = new Vector3(1000f, 0f, 0f);
        foreach (GameObject BGMold in BGMPlaying.Values)
        {
            Destroy(BGMold);
        }
        BGMPlaying = new Dictionary<string, GameObject> { { BGMCueName, BGM } };
        audioSource.clip = webAudio[BGMCueName];
        StartCoroutine(PlayBGMFadeIn(BGM, FadeInSec));
    }
    private void StopBGM(float FadeOutSec)
    {
        foreach (GameObject BGMold in BGMPlaying.Values)
        {
            StartCoroutine(PlayBGMFadeOut(BGMold, FadeOutSec));
        }
        BGMPlaying = new Dictionary<string, GameObject>();
    }
    private void PlaySE(string SeCueName, float FadeInSec, float FadeOutSec)
    {
        GameObject SE = new GameObject(SeCueName);
        SE.transform.SetParent(Audios.transform);
        AudioSource audioSource = SE.AddComponent<AudioSource>();
        SE.transform.position = new Vector3(0f, 800f, 0f);
        audioSource.clip = webAudio[SeCueName];
        if (SeCueName.EndsWith("lp") || FadeInSec > 0)
        {
            audioSource.loop = true;
            if (FadeOutSec == 0) { FadeOutSec = 1f; }
            StartCoroutine(PlaySELoop(SE, FadeInSec, FadeOutSec));
        }
        else
        {
            StartCoroutine(PlaySEFade(SE));
        }
    }
    private void StopSE()
    {
        StartCoroutine(StoppingSE());
    }
    private void WaitSE()
    {
        StartCoroutine(WaitForSE());
    }
    private void PlayVOICECueName(string ADVCharaID, string CueName)
    {
        List<string> voicePaths = new List<string>();
        advcharacterlist_Params charaParams = GetCharaParams(ADVCharaID);
        string voiceName = ADVCharaID + "_" + CueName;
        string voicePathBase = "";
        if (charaParams.m_CueSheet != "")
        {
            voicePathBase = charaParams.m_CueSheet + @"\" + CueName + "_";
        }
        else if (charaParams.m_NamedType != -1)
        {
            string charaResourceName = advCharaVoiceLabel.m_Params.First(param => param.m_NamedType == charaParams.m_NamedType).m_VoiceLabel;
            voicePathBase = charaResourceName + @"\" + CueName + "_";
        }
        for (int j = 0; j < 100; j++)
        {
            if (webAudio.ContainsKey(voicePathBase + j.ToString("D2")))
            {
                voicePaths.Add(j.ToString("D2"));
            }
            else { break; }
        }
        System.Random random = new System.Random();
        string voicePath = voicePathBase + voicePaths[random.Next(voicePaths.Count)];
        GameObject voice = new GameObject(voiceName);
        voice.transform.SetParent(Audios.transform);
        AudioSource audioSource = voice.AddComponent<AudioSource>();
        voice.transform.position = new Vector3(-1000f, 0f, 0f);
        audioSource.clip = webAudio[voicePath];
        StartCoroutine(PlayVoice(voice));
    }
    private void PlayFULLVOICE(string CueName)
    {
        string voicePath = advList.m_Params.First(param => param.m_AdvID == ADVID).m_CueSheet + "_" + CueName;
        GameObject voice = new GameObject(CueName);
        voice.transform.SetParent(Audios.transform);
        AudioSource audioSource = voice.AddComponent<AudioSource>();
        voice.transform.position = new Vector3(-1000f, 0f, 0f);
        audioSource.clip = webAudio[voicePath];
        StartCoroutine(PlayVoice(voice));
    }
    private void WaitVOICE()
    {
        StartCoroutine(WaitForVOICE());
    }
    private void StopVOICE()
    {
        StartCoroutine(StoppingVOICE());
    }
    private void UpdateGame()
    {
        foreach (string ADVCharaID in isUpdateCharaPosition)
        {
            if (isUpdateCharaDestroy.Contains(ADVCharaID)) { continue; }
            UpdateCharaPosition(ADVCharaID);
        }
        isUpdateCharaPosition.Clear();
        foreach (string ADVCharaID in isUpdateCharaPose)
        {
            if (isUpdateCharaDestroy.Contains(ADVCharaID)) { continue; }
            UpdateCharaPose(ADVCharaID);
        }
        isUpdateCharaPose.Clear();
        foreach (string ADVCharaID in isUpdateCharaFace)
        {
            if (isUpdateCharaDestroy.Contains(ADVCharaID)) { continue; }
            UpdateCharaFace(ADVCharaID);
        }
        isUpdateCharaFace.Clear();
        foreach (string ADVCharaID in isUpdateCharaFaceTexture)
        {
            if (isUpdateCharaDestroy.Contains(ADVCharaID)) { continue; }
            UpdateCharaFaceTexture(ADVCharaID);
        }
        isUpdateCharaFaceTexture.Clear();
        foreach (string ADVCharaID in isUpdateCharaFade)
        {
            if (isUpdateCharaDestroy.Contains(ADVCharaID)) { continue; }
            UpdateCharaFade(ADVCharaID);
        }
        isUpdateCharaFade.Clear();
        foreach (string ADVCharaID in isUpdateCharaTransparency)
        {
            if (isUpdateCharaDestroy.Contains(ADVCharaID)) { continue; }
            UpdateCharaTransparency(ADVCharaID);
        }
        isUpdateCharaTransparency.Clear();
        foreach (string ADVCharaID in isUpdateCharaHDRFactor)
        {
            if (isUpdateCharaDestroy.Contains(ADVCharaID)) { continue; }
            UpdateCharaHDRFactor(ADVCharaID);
        }
        isUpdateCharaHDRFactor.Clear();
        foreach (string ADVCharaID in isUpdateCharaDestroy)
        {
            foreach (Coroutine coroutine in charaCoroutinesDict[ADVCharaID].Values)
            {
                if (coroutine == null) { continue; }
                StopCoroutine(coroutine);
            }
            while (CharaMoving.Remove(ADVCharaID)) { }
            while (CharaRotating.Remove(ADVCharaID)) { }
            while (CharaMotioning.Remove(ADVCharaID)) { }
            while (CharaFading.Remove(ADVCharaID)) { }
            //charaPriorityFirst.RemoveAll(item=>item==ADVCharaID);
            //charaPriorityMid.RemoveAll(item=>item==ADVCharaID);
            //charaPriorityLast.RemoveAll(item=>item==ADVCharaID);
            while (highlightChara.Remove(ADVCharaID)) { }
            while (forceHighlight.Remove(ADVCharaID)) { }
            while (forceShading.Remove(ADVCharaID)) { }
            CharasExist.Remove(ADVCharaID);
            CharasLayer.Remove(ADVCharaID);
            charaCoroutinesDict[ADVCharaID] = new Dictionary<string, Coroutine>{
                {"fade",null},{"move",null},{"mot",null},{"rotate",null},{"shake",null},{"transparency",null},{"destroy",null},
            };
            GameObject chara = FindCached(ADVCharaID);
            foreach(SpriteRenderer spriteRenderer in chara.GetComponentsInChildren<SpriteRenderer>())
            {
                Destroy(spriteRenderer.material);
            }
            Destroy(chara);
            RemoveCachedGameObject(ADVCharaID);
            GameObject charaCamera = FindCached(ADVCharaID + "_Camera");
            Destroy(charaCamera);
            RemoveCachedGameObject(ADVCharaID + "_Camera");
            GameObject charaRT = FindCached(ADVCharaID + "_RT");
            Destroy(charaRT.GetComponent<MeshRenderer>().material);
            Destroy(charaRT);
            RemoveCachedGameObject(ADVCharaID + "_RT");
            RemoveCachedGameObject(ADVCharaID + "_Face");
            RemoveCachedGameObject(ADVCharaID + "_Mask");
        }
        isUpdateCharaDestroy.Clear();
        if (isUpdateBGPosition)
        {
            UpdateBGPosition();
            isUpdateBGPosition = false;
        }
        if (isUpdateBGScale)
        {
            UpdateBGScale();
            isUpdateBGScale = false;
        }
        if (isUpdateHighlight)
        {
            UpdateHighlight();
            isUpdateHighlight = false;
        }
        if (isUpdatePriority)
        {
            UpdatePriority();
            isUpdatePriority = false;
        }
    }
    private HashSet<string> isUpdateCharaDestroy = new HashSet<string>();
    private HashSet<string> isUpdateCharaPosition = new HashSet<string>();
    private HashSet<string> isUpdateCharaPose = new HashSet<string>();
    private HashSet<string> isUpdateCharaFace = new HashSet<string>();
    private HashSet<string> isUpdateCharaFaceTexture = new HashSet<string>();
    private HashSet<string> isUpdateCharaFade = new HashSet<string>();
    private HashSet<string> isUpdateCharaTransparency = new HashSet<string>();
    private HashSet<string> isUpdateCharaHDRFactor = new HashSet<string>();
    private bool isUpdateBGPosition = false;
    private bool isUpdateBGScale = false;
    private bool isUpdateHighlight = false;
    private bool isUpdatePriority = false;
    private void UpdateCharaPosition(string ADVCharaID)
    {
        GameObject chara = FindCached(ADVCharaID);
        if (chara == null)
        {
            //Debug.LogError("Chara Not Found: "+ADVCharaID);
            return;
        }
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        RectTransform rectTransform = chara.GetComponent<RectTransform>();
        double a = 1 - Math.Cos(charaProperties.Angle * Mathf.Deg2Rad);
        double b = -Math.Sin(charaProperties.Angle * Mathf.Deg2Rad);
        double dx = charaProperties.RotateCenter.x * a - charaProperties.RotateCenter.y * b;
        double dy = charaProperties.RotateCenter.y * a + charaProperties.RotateCenter.x * b;
        float x = (float)dx + GetCharaParamsPose(ADVCharaID).m_OffsetX + charaProperties.Position.x + charaProperties.MotOffset.x + charaProperties.ShakeOffset.x;
        float y = (float)dy + GetCharaParamsPose(ADVCharaID).m_OffsetY + charaProperties.Position.y + charaProperties.MotOffset.y + charaProperties.ShakeOffset.y;
        rectTransform.anchoredPosition = new Vector3(x, y + 10000f, 0f);
        rectTransform.localRotation = Quaternion.Euler(0f, 0f, charaProperties.Angle);
        rectTransform.localScale = new Vector3(charaProperties.Scale, charaProperties.Scale, 1f);
    }
    private void UpdateCharaPose(string ADVCharaID)
    {
        GameObject chara = FindCached(ADVCharaID);
        if (chara == null)
        {
            //Debug.LogError("Chara Not Found: "+ADVCharaID);
            return;
        }
        advcharacterlist_Params param = GetCharaParams(ADVCharaID);
        advclist_Params_Data Pose = GetCharaParamsPose(ADVCharaID);
        if (Pose.m_FaceReferenceImageType == 0)
        {
            charaPropertiesDict[ADVCharaID].PoseID = Pose.m_PoseID;
            string posePath = param.m_ResourceBaseName + "_StandPic_" + Pose.m_PoseID;
            SpriteRenderer spriteRenderer = chara.GetComponent<SpriteRenderer>();
            Texture2D texture = new Texture2D(0, 0);
            if (webTexture.ContainsKey(posePath))
            {
                texture = webTexture[posePath];
            }
            else
            {
                //Debug.LogError("Texture Not Found: "+posePath);
            }
            texture.wrapMode = TextureWrapMode.Clamp;
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0f), 1, 0, SpriteMeshType.FullRect);
            spriteRenderer.sprite = sprite;
            spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
            RectTransform rectTransform = chara.GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(texture.width, texture.height);
        }
    }
    private void UpdateCharaFace(string ADVCharaID)
    {
        GameObject chara = FindCached(ADVCharaID);
        if (chara == null)
        {
            //Debug.LogError("Chara Not Found: "+ADVCharaID);
            return;
        }
        advclist_Params_Data Pose = GetCharaParamsPose(ADVCharaID);
        GameObject charaMask = FindCached(ADVCharaID + "_Mask");
        RectTransform rectTransform = charaMask.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector3(Pose.m_FacePicX, -Pose.m_FacePicY, 0f);
        GameObject charaFace = FindCached(ADVCharaID + "_Face");
        rectTransform = charaFace.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector3(Pose.m_FacePicX, -Pose.m_FacePicY, 0f);
    }
    private void UpdateCharaFaceTexture(string ADVCharaID)
    {
        GameObject chara = FindCached(ADVCharaID);
        if (chara == null)
        {
            //Debug.LogError("Chara Not Found: "+ADVCharaID);
            return;
        }
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        advcharacterlist_Params param = GetCharaParams(ADVCharaID);
        advclist_Params_Data Pose = GetCharaParamsPose(ADVCharaID);
        GameObject charaMask = FindCached(ADVCharaID + "_Mask");
        Texture2D texture = new Texture2D(0, 0);
        string maskPath = param.m_ResourceBaseName + "_Face_" + Pose.m_PoseID + "_Default";
        if (webTexture.ContainsKey(maskPath))
        {
            texture = webTexture[maskPath];
        }
        else
        {
            //Debug.LogError("Texture Not Found: "+maskPath);
        }
        texture.wrapMode = TextureWrapMode.Clamp;
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(Pose.m_FacePivotX, Pose.m_FacePivotY), 1, 0, SpriteMeshType.FullRect);
        charaMask.GetComponent<SpriteMask>().sprite = sprite;
        GameObject charaFace = FindCached(ADVCharaID + "_Face");
        texture = new Texture2D(0, 0);
        string facePath = param.m_ResourceBaseName + "_Face_" + Pose.m_PoseID + "_" + charaFaceID[charaProperties.FaceID];
        if (webTexture.ContainsKey(facePath))
        {
            texture = webTexture[facePath];
        }
        else
        {
            //Debug.LogError("Texture Not Found: "+facePath);
        }
        texture.wrapMode = TextureWrapMode.Clamp;
        sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(Pose.m_FacePivotX, Pose.m_FacePivotY), 1, 0, SpriteMeshType.FullRect);
        SpriteRenderer spriteRenderer = charaFace.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;
    }
    private void UpdateCharaFade(string ADVCharaID)
    {
        GameObject chara = FindCached(ADVCharaID);
        if (chara == null)
        {
            //Debug.LogError("Chara Not Found: "+ADVCharaID);
            return;
        }
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        SpriteRenderer sr = chara.GetComponent<SpriteRenderer>();
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, charaProperties.Fade);
        FindCached(ADVCharaID + "_Face").GetComponent<SpriteRenderer>().color = new Color(sr.color.r, sr.color.g, sr.color.b, charaProperties.Fade);
    }
    private void UpdateCharaTransparency(string ADVCharaID)
    {
        GameObject chara = FindCached(ADVCharaID + "_RT");
        if (chara == null)
        {
            //Debug.LogError("Chara Not Found: "+ADVCharaID);
            return;
        }
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        chara.GetComponent<MeshRenderer>().material.SetColor(_MeshColor, new Color(1f, 1f, 1f, charaProperties.Transparency));
    }
    private void UpdateCharaHDRFactor(string ADVCharaID)
    {
        GameObject chara = FindCached(ADVCharaID + "_RT");
        if (chara == null)
        {
            //Debug.LogError("Chara Not Found: "+ADVCharaID);
            return;
        }
        CharaProperties charaProperties = charaPropertiesDict[ADVCharaID];
        chara.GetComponent<MeshRenderer>().material.SetFloat(_HDRFactor, charaProperties.HDRFactor);
    }
    private void UpdateBGPosition()
    {
        foreach (uint id in bgCoroutinesDict.Keys)
        {
            GameObject bg = FindCached("bg_" + id.ToString());
            BGProperties bgProperties = bg.GetComponent<BGProperties>();
            bg.GetComponent<RectTransform>().anchoredPosition = bgProperties.Position + bgProperties.ShakeOffset;
        }
    }
    private void UpdateBGScale()
    {
        foreach (uint id in bgCoroutinesDict.Keys)
        {
            GameObject bg = FindCached("bg_" + id.ToString());
            BGProperties bgProperties = bg.GetComponent<BGProperties>();
            bg.GetComponent<RectTransform>().localScale = new Vector3(0.6510415f * bgProperties.Scale, 0.6510415f * bgProperties.Scale, 1f);
        }
    }
    private void UpdateHighlight()
    {
        foreach (string ADVCharaID in CharasExist.Keys)
        {
            if (forceHighlight.Contains(ADVCharaID))
            {
                Highlight(ADVCharaID);
            }
            else if (forceShading.Contains(ADVCharaID))
            {
                Shading(ADVCharaID);
            }
            else if (talkingChara.Contains(ADVCharaID) && textCanvasVisible)
            {
                Highlight(ADVCharaID);
            }
            else
            {
                Shading(ADVCharaID);
            }
        }
    }
    private void UpdatePriority()
    {
        int priority = -1000;
        GameObject chara;
        foreach (string ADVCharaID in talkingChara)
        {
            ForwardChara(ADVCharaID);
        }
        foreach (string ADVCharaID in charaPriorityLast)
        {
            chara = FindCached(ADVCharaID + "_RT");
            if (chara == null) { continue; }
            chara.GetComponent<MeshRenderer>().sortingOrder = priority;
            priority++;
        }
        foreach (string ADVCharaID in charaPriorityMid)
        {
            chara = FindCached(ADVCharaID + "_RT");
            if (chara == null) { continue; }
            chara.GetComponent<MeshRenderer>().sortingOrder = priority;
            priority++;
        }
        foreach (string ADVCharaID in charaPriorityFirst)
        {
            chara = FindCached(ADVCharaID + "_RT");
            if (chara == null) { continue; }
            chara.GetComponent<MeshRenderer>().sortingOrder = priority;
            priority++;
        }
    }
    private void CreateCharaProperties(string ADVCharaID, float x, float y)
    {
        if (!charaPropertiesDict.ContainsKey(ADVCharaID))
        {
            CharaProperties charaProperties = new CharaProperties();
            charaProperties.Fade = 0f;
            charaProperties.Transparency = 1f;
            charaProperties.FaceID = 0;
            charaProperties.PoseID = 0;
            charaProperties.Position = new Vector2(x, y);
            charaProperties.Scale = 1f;
            charaProperties.MotOffset = new Vector2(0f, 0f);
            charaProperties.Angle = 0f;
            charaProperties.RotateCenter = new Vector2(0f, 0f);
            charaProperties.HDRFactor = 1f;
            charaPropertiesDict.Add(ADVCharaID, charaProperties);
            charaCoroutinesDict.Add(ADVCharaID, new Dictionary<string, Coroutine>{
                {"fade",null},{"move",null},{"mot",null},{"rotate",null},{"shake",null},{"transparency",null},{"destroy",null},
            });
        }
    }
    void Update()
    {
        Time.timeScale = TimeScale;
#if !UNITY_WEBGL
        if (Input.GetKeyDown(KeyCode.F11))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
#endif
        if (JsonLoading)
        {
            return;
        }
        if (StartLoading)
        {
            StopAllCoroutines();
            StartCoroutine(StartingLoading());
            StartLoading = false;
#if !UNITY_WEBGL
            SetWindowText(GetActiveWindow(), "krfadvplayer");
#endif
        }
        if (Playing)
        {
            if (Input.GetKeyUp(KeyCode.A))
            {
                auto = !auto;
            }
            if (Input.GetMouseButtonUp(0))
            {
                StopCoroutine(PenCoroutine);
                PenCoroutine = StartCoroutine(PenClick());
            }
            if (advScriptProgress == advScript.m_Params[0].FuncParam.Count && nextCommand)
            {
                if (ADVIndex < ADVIDs.Count)
                {
                    foreach (SpriteRenderer spriteRenderer in canvas.GetComponentsInChildren<SpriteRenderer>())
                    {
                        Destroy(spriteRenderer.material);
                    }
                    foreach (Transform transform in canvas.GetComponentsInChildren<Transform>()[1..])
                    {
                        Destroy(transform.gameObject);
                    }
                    foreach (Transform transform in Audios.GetComponentsInChildren<Transform>()[1..])
                    {
                        Destroy(transform.gameObject);
                    }
                    foreach (Transform transform in effectCanvas.GetComponentsInChildren<Transform>()[1..])
                    {
                        Destroy(transform.gameObject);
                    }
                    foreach (Transform transform in particleObj.GetComponentsInChildren<Transform>()[1..])
                    {
                        Destroy(transform.gameObject);
                    }
                    foreach (Dictionary<string, Coroutine> coroutines in charaCoroutinesDict.Values)
                    {
                        foreach (Coroutine coroutine in coroutines.Values)
                        {
                            if (coroutine == null) { continue; }
                            StopCoroutine(coroutine);
                        }
                    }
                    canvas.transform.position = new Vector3(0f, 0f, 0f);
                    ADVIndex++;
                    if (ADVIndex == ADVIDs.Count)
                    {
                        StartCoroutine(EndingLoading());
                        Playing = false;
                        return;
                    }
                    ADVID = ADVIDs[ADVIndex];
                    while (!advScripts.ContainsKey(ADVID))
                    {
                        ADVIndex++;
                        if (ADVIndex == ADVIDs.Count)
                        {
                            StartCoroutine(EndingLoading());
                            Playing = false;
                            return;
                        }
                        ADVID = ADVIDs[ADVIndex];
                    }
#if !UNITY_WEBGL
                    SetWindowText(GetActiveWindow(), "krfadvplayer - " + ADVID.ToString());
#endif
                    advScript = advScripts[ADVID];
                    advScriptText = advScriptTexts[ADVID];
                    SetUp();
                    Debug.Log(ADVID);
                }
                else
                {
                    StartCoroutine(EndingLoading());
                    Playing = false;
                    return;
                }
            }
            if (preRead)
            {
                preRead = false;
                int[] CharaShotsPreRead = new int[5] { 0, 1, 2, 3, 4 };
                foreach (class_FuncParam func in advScripts[ADVID].m_Params[0].FuncParam)
                {
                    switch (func.funcName)
                    {
                        case "SetCharaShotPosition":
                            CharaShotsPreRead[0] = int.Parse(func.m_value1);
                            if (CharaShotsPreRead[0] == int.Parse(func.m_value2))
                            {
                                CharaShotsPreRead[1] = -1;
                            }
                            else { CharaShotsPreRead[1] = int.Parse(func.m_value2); }
                            if (func.argNum == 5)
                            {
                                if (CharaShotsPreRead[0] == int.Parse(func.m_value3) || CharaShotsPreRead[1] == int.Parse(func.m_value3))
                                {
                                    CharaShotsPreRead[2] = -1;
                                }
                                else { CharaShotsPreRead[2] = int.Parse(func.m_value3); }
                                if (CharaShotsPreRead[0] == int.Parse(func.m_value4) || CharaShotsPreRead[1] == int.Parse(func.m_value4) || CharaShotsPreRead[2] == int.Parse(func.m_value4))
                                {
                                    CharaShotsPreRead[3] = -1;
                                }
                                else { CharaShotsPreRead[3] = int.Parse(func.m_value4); }
                                if (CharaShotsPreRead[0] == int.Parse(func.m_value5) || CharaShotsPreRead[1] == int.Parse(func.m_value5) || CharaShotsPreRead[2] == int.Parse(func.m_value5) || CharaShotsPreRead[3] == int.Parse(func.m_value5))
                                {
                                    CharaShotsPreRead[4] = -1;
                                }
                                else { CharaShotsPreRead[4] = int.Parse(func.m_value5); }
                            }
                            break;
                        case "CharaIn":
                            if (func.argNum == 2)
                            {
                                CreateCharaProperties(func.m_value1, charaShotPx[int.Parse(func.m_value2)], 0);
                            }
                            else { CreateCharaProperties(func.m_value1, charaShotPx[int.Parse(func.m_value3) == 0 ? -1 : -2], 0); }
                            break;
                        case "CharaInFade":
                            if (func.argNum == 3)
                            {
                                CreateCharaProperties(func.m_value1, charaShotPx[int.Parse(func.m_value2)], 0);
                            }
                            else { CreateCharaProperties(func.m_value1, charaShotPx[int.Parse(func.m_value2) == 0 ? -1 : -2], 0); }
                            break;
                        case "CharaPosition":
                            CreateCharaProperties(func.m_value1, charaShotPx[int.Parse(func.m_value2)] + float.Parse(func.m_value3), float.Parse(func.m_value4));
                            break;
                        case "CharaMove":
                            CreateCharaProperties(func.m_value1, charaShotPx[int.Parse(func.m_value2) == 0 ? -1 : -2], 0);
                            break;
                        case "CharaShot":
                            if (GetCharaParams(func.m_value1) != null)
                            {
                                CreateCharaProperties(func.m_value1, charaShotPx[CharaShotsPreRead[0]], 0);
                            }
                            if (GetCharaParams(func.m_value2) != null)
                            {
                                CreateCharaProperties(func.m_value2, charaShotPx[CharaShotsPreRead[1]], 0);
                            }
                            if (GetCharaParams(func.m_value3) != null)
                            {
                                CreateCharaProperties(func.m_value3, charaShotPx[CharaShotsPreRead[2]], 0);
                            }
                            if (GetCharaParams(func.m_value4) != null)
                            {
                                CreateCharaProperties(func.m_value4, charaShotPx[CharaShotsPreRead[3]], 0);
                            }
                            if (GetCharaParams(func.m_value5) != null)
                            {
                                CreateCharaProperties(func.m_value5, charaShotPx[CharaShotsPreRead[4]], 0);
                            }
                            break;
                        case "CharaShotFade":
                            if (GetCharaParams(func.m_value1) != null)
                            {
                                CreateCharaProperties(func.m_value1, charaShotPx[CharaShotsPreRead[0]], 0);
                            }
                            if (GetCharaParams(func.m_value2) != null)
                            {
                                CreateCharaProperties(func.m_value2, charaShotPx[CharaShotsPreRead[1]], 0);
                            }
                            if (GetCharaParams(func.m_value3) != null)
                            {
                                CreateCharaProperties(func.m_value3, charaShotPx[CharaShotsPreRead[2]], 0);
                            }
                            if (GetCharaParams(func.m_value4) != null)
                            {
                                CreateCharaProperties(func.m_value4, charaShotPx[CharaShotsPreRead[3]], 0);
                            }
                            if (GetCharaParams(func.m_value5) != null)
                            {
                                CreateCharaProperties(func.m_value5, charaShotPx[CharaShotsPreRead[4]], 0);
                            }
                            break;
                        case "SetTarget":
                            if (GetCharaParams(func.m_value1) != null)
                            {
                                CreateCharaProperties(func.m_value1, charaShotPx[1], 0);
                            }
                            if (GetCharaParams(func.m_value2) != null)
                            {
                                CreateCharaProperties(func.m_value2, charaShotPx[2], 0);
                            }
                            if (GetCharaParams(func.m_value3) != null)
                            {
                                CreateCharaProperties(func.m_value3, charaShotPx[3], 0);
                            }
                            if (GetCharaParams(func.m_value4) != null)
                            {
                                CreateCharaProperties(func.m_value4, charaShotPx[4], 0);
                            }
                            if (GetCharaParams(func.m_value5) != null)
                            {
                                CreateCharaProperties(func.m_value5, charaShotPx[5], 0);
                            }
                            break;
                        default:
                            break;
                    }
                }
                return;
            }
            if (Talking)
            {
                if ((Input.GetMouseButtonUp(0) || (Input.GetKey(KeyCode.Space) && DebugMode) || QuickPlay) && getInput)
                {
                    StartCoroutine(inputCD(0f));
                    auto = false;
                    foreach (Coroutine coroutine in autoSkipCoroutine)
                    {
                        StopCoroutine(coroutine);
                    }
                    TalkQuickEnd = true;
                }
            }
            else if (PlayingCaption)
            {
                if ((Input.GetMouseButtonUp(0) || (Input.GetKey(KeyCode.Space) && DebugMode) || QuickPlay) && getInput)
                {
                    StartCoroutine(inputCD(0f));
                    auto = false;
                    foreach (Coroutine coroutine in autoSkipCoroutine)
                    {
                        StopCoroutine(coroutine);
                    }
                    WaitForClickCaption = false;
                }
                if (!auto)
                {
                    foreach (Coroutine coroutine in autoSkipCoroutine)
                    {
                        //StopCoroutine(coroutine);
                    }
                }
                else
                {
                    if (autoClick)
                    {
                        autoClick = false;
                        foreach (Coroutine coroutine in autoSkipCoroutine)
                        {
                            StopCoroutine(coroutine);
                        }
                        WaitForClickCaption = false;
                    }
                }
            }
            else if (Waiting.Count == 0)
            {
                if (WaitForClick)
                {
                    if ((Input.GetMouseButtonUp(0) || (Input.GetKey(KeyCode.Space) && DebugMode) || QuickPlay) && getInput)
                    {
                        StartCoroutine(inputCD(0f));
                        auto = false;
                        foreach (Coroutine coroutine in autoSkipCoroutine)
                        {
                            StopCoroutine(coroutine);
                        }
                        nextCommand = true;
                        WaitForClick = false;
                    }
                    if (!auto)
                    {
                        foreach (Coroutine coroutine in autoSkipCoroutine)
                        {
                            //StopCoroutine(coroutine);
                        }
                    }
                    else
                    {
                        if (autoClick)
                        {
                            autoClick = false;
                            foreach (Coroutine coroutine in autoSkipCoroutine)
                            {
                                StopCoroutine(coroutine);
                            }
                            nextCommand = true;
                            WaitForClick = false;
                        }
                    }
                }
                else { nextCommand = true; }
            }
            while (advScriptProgress < advScript.m_Params[0].FuncParam.Count && nextCommand)
            {
                class_FuncParam func = advScript.m_Params[0].FuncParam[advScriptProgress];
                if (!QuickPlay)
                {
                    Debug.Log(func.funcName + "(" + func.m_value1 + "," + func.m_value2 + "," + func.m_value3 + "," + func.m_value4 + "," + func.m_value5 + "," + func.m_value6 + ")");
                }
                uint m_ID;
                uint m_TextID;
                uint textID;
                uint m_Alpha;
                uint m_VisibleFlg;
                int m_FaceID;
                int m_StartSide;
                int m_EndSide;
                int m_CurveType;
                int m_StandPosition;
                int m_Anchor;
                int m_ShakeType;
                int m_CharaAnchor;
                int m_ADVCharaPos;
                int m_ADVCharaPos2;
                int m_ADVCharaPos3;
                int m_ADVCharaPos4;
                int m_ADVCharaPos5;
                int curveType;
                int m_EmoPosition;
                int m_ScreenAnchor;
                uint m_R;
                uint m_G;
                uint m_B;
                uint m_Enable;
                string m_RGBA;
                string m_FileNameWithoutExt;
                string m_PoseName;
                string m_MotID;
                string m_EmotionID;
                string m_BGMCueName;
                string m_SeCueName;
                string m_CueName;
                string m_StartColor;
                string m_EndColor;
                string m_RGBAStart;
                string m_RGBAEnd;
                string m_ADVCharaID;
                string m_ADVCharaID2;
                string m_ADVCharaID3;
                string m_ADVCharaID4;
                string m_ADVCharaID5;
                string m_ADVCharaID1;
                string fileName;
                string rgba;
                string m_effectID;
                string m_afterEffectID;
                string m_stEffectID;
                string m_lpEffectID;
                string m_EdEffectID;
                sbyte m_IgnoreParticle;
                float m_Sec;
                float m_Time;
                float m_XOffset;
                float m_FadeInSec;
                float m_FadeOutSec;
                float m_Xoffset;
                float m_Yoffset;
                float m_Scale;
                float m_X;
                float m_Y;
                float m_Rotate;
                float m_PivotX;
                float m_PivotY;
                float m_Angle;
                float m_Value;
                float sec;
                float posX;
                float posY;
                float sclX;
                float sclY;
                float delay;
                float width;
                float height;
                advScriptProgress++;
                switch (func.funcName)
                {
                    case "BGVisible":
                        m_ID = uint.Parse(func.m_value1);
                        m_FileNameWithoutExt = func.m_value2;
                        BGVisible(m_ID, m_FileNameWithoutExt);
                        break;
                    case "SetCharaShotPosition":
                        m_ADVCharaPos = int.Parse(func.m_value1);
                        m_ADVCharaPos2 = int.Parse(func.m_value2);
                        m_ADVCharaPos3 = CharaShots[2];
                        m_ADVCharaPos4 = CharaShots[3];
                        m_ADVCharaPos5 = CharaShots[4];
                        if (func.argNum == 5)
                        {
                            m_ADVCharaPos3 = int.Parse(func.m_value3);
                            m_ADVCharaPos4 = int.Parse(func.m_value4);
                            m_ADVCharaPos5 = int.Parse(func.m_value5);
                        }
                        SetCharaShotPosition(m_ADVCharaPos, m_ADVCharaPos2, m_ADVCharaPos3, m_ADVCharaPos4, m_ADVCharaPos5);
                        break;
                    case "CharaShot":
                        m_ADVCharaID = func.m_value1;
                        m_ADVCharaID2 = func.m_value2;
                        m_ADVCharaID3 = func.m_value3;
                        m_ADVCharaID4 = func.m_value4;
                        m_ADVCharaID5 = func.m_value5;
                        CharaShot(m_ADVCharaID, m_ADVCharaID2, m_ADVCharaID3, m_ADVCharaID4, m_ADVCharaID5);
                        break;
                    case "CharaIn":
                        m_ADVCharaID = func.m_value1;
                        m_StandPosition = int.Parse(func.m_value2);
                        if (func.argNum == 2)
                        {
                            CharaIn(m_ADVCharaID, m_StandPosition);
                        }
                        else
                        {
                            m_StartSide = int.Parse(func.m_value3);
                            m_Sec = float.Parse(func.m_value4);
                            m_CurveType = int.Parse(func.m_value5);
                            if (func.argNum == 6)
                            {
                                m_XOffset = float.Parse(func.m_value6);
                            }
                            else { m_XOffset = 0; }
                            CharaIn(m_ADVCharaID, m_StandPosition, m_StartSide, m_Sec, m_CurveType, m_XOffset);
                        }
                        break;
                    case "CharaOut":
                        m_ADVCharaID = func.m_value1;
                        if (func.argNum == 1)
                        {
                            CharaOut(m_ADVCharaID);
                        }
                        else
                        {
                            m_EndSide = int.Parse(func.m_value2);
                            m_Sec = float.Parse(func.m_value3);
                            m_CurveType = int.Parse(func.m_value4);
                            CharaOut(m_ADVCharaID, m_EndSide, m_Sec, m_CurveType);
                        }
                        break;
                    case "CharaOutAll":
                        CharaOutAll();
                        break;
                    case "CharaInFade":
                        m_ADVCharaID = func.m_value1;
                        m_StandPosition = int.Parse(func.m_value2);
                        switch (func.argNum)
                        {
                            case 3:
                                m_Sec = float.Parse(func.m_value3);
                                CharaInFade(m_ADVCharaID, m_StandPosition, m_Sec);
                                break;
                            case 5:
                                m_StartSide = int.Parse(func.m_value3);
                                m_Sec = float.Parse(func.m_value4);
                                m_CurveType = int.Parse(func.m_value5);
                                CharaInFade(m_ADVCharaID, m_StandPosition, m_Sec, m_StartSide, m_CurveType, 0);
                                break;
                            case 6:
                                m_StartSide = int.Parse(func.m_value3);
                                m_Sec = float.Parse(func.m_value4);
                                m_CurveType = int.Parse(func.m_value5);
                                m_XOffset = float.Parse(func.m_value6);
                                CharaInFade(m_ADVCharaID, m_StandPosition, m_Sec, m_StartSide, m_CurveType, m_XOffset);
                                break;
                        }
                        break;
                    case "CharaOutFade":
                        m_ADVCharaID = func.m_value1;
                        switch (func.argNum)
                        {
                            case 2:
                                m_Sec = float.Parse(func.m_value2);
                                CharaOutFade(m_ADVCharaID, m_Sec);
                                break;
                            case 4:
                                m_EndSide = int.Parse(func.m_value2);
                                m_Sec = float.Parse(func.m_value3);
                                m_CurveType = int.Parse(func.m_value4);
                                CharaOutFade(m_ADVCharaID, m_Sec, m_EndSide, m_CurveType);
                                break;
                        }
                        break;
                    case "CharaShotFade":
                        m_ADVCharaID = func.m_value1;
                        m_ADVCharaID2 = func.m_value2;
                        m_ADVCharaID3 = func.m_value3;
                        m_ADVCharaID4 = func.m_value4;
                        m_ADVCharaID5 = func.m_value5;
                        if (func.argNum == 5)
                        {
                            m_Sec = 0;
                        }
                        else
                        {
                            m_Sec = float.Parse(func.m_value6);
                        }
                        CharaShotFade(m_ADVCharaID, m_ADVCharaID2, m_ADVCharaID3, m_ADVCharaID4, m_ADVCharaID5, m_Sec);
                        break;
                    case "CharaOutAllFade":
                        m_Sec = float.Parse(func.m_value1);
                        CharaOutAllFade(m_Sec);
                        break;
                    case "CharaPosition":
                        m_ADVCharaID = func.m_value1;
                        m_StandPosition = int.Parse(func.m_value2);
                        m_Xoffset = float.Parse(func.m_value3);
                        m_Yoffset = float.Parse(func.m_value4);
                        CharaPosition(m_ADVCharaID, m_StandPosition, m_Xoffset, m_Yoffset);
                        break;
                    case "CharaMove":
                        m_ADVCharaID = func.m_value1;
                        m_StandPosition = int.Parse(func.m_value2);
                        m_Xoffset = float.Parse(func.m_value3);
                        switch (func.argNum)
                        {
                            case 5:
                                m_Sec = float.Parse(func.m_value4);
                                m_CurveType = int.Parse(func.m_value5);
                                m_Yoffset = 0;
                                break;
                            default:
                                m_Yoffset = float.Parse(func.m_value4);
                                m_Sec = float.Parse(func.m_value5);
                                m_CurveType = int.Parse(func.m_value6);
                                break;
                        }
                        CharaMove(m_ADVCharaID, m_StandPosition, m_Xoffset, m_Yoffset, m_Sec, m_CurveType);
                        break;
                    case "CharaFace":
                        m_ADVCharaID = func.m_value1;
                        m_FaceID = int.Parse(func.m_value2);
                        CharaFace(m_ADVCharaID, m_FaceID);
                        break;
                    case "CharaPose":
                        m_ADVCharaID = func.m_value1;
                        m_PoseName = func.m_value2;
                        CharaPose(m_ADVCharaID, m_PoseName);
                        break;
                    case "CharaHighlight":
                        m_ADVCharaID = func.m_value1;
                        CharaHighlight(m_ADVCharaID);
                        break;
                    case "CharaHighlightAll":
                        CharaHighlightAll();
                        break;
                    case "CharaHighlightReset":
                        m_ADVCharaID = func.m_value1;
                        CharaHighlightReset(m_ADVCharaID);
                        break;
                    case "CharaHighlightResetAll":
                        CharaHighlightResetAll();
                        break;
                    case "CharaShading":
                        m_ADVCharaID = func.m_value1;
                        CharaShading(m_ADVCharaID);
                        break;
                    case "CharaShadingAll":
                        CharaShadingAll();
                        break;
                    case "CharaPriorityTop":
                        m_ADVCharaID = func.m_value1;
                        CharaPriorityTop(m_ADVCharaID);
                        break;
                    case "CharaPriorityTopSet":
                        m_ADVCharaID = func.m_value1;
                        CharaPriorityTopSet(m_ADVCharaID);
                        break;
                    case "CharaPriorityBottom":
                        m_ADVCharaID = func.m_value1;
                        CharaPriorityBottom(m_ADVCharaID);
                        break;
                    case "CharaPriorityBottomSet":
                        m_ADVCharaID = func.m_value1;
                        CharaPriorityBottomSet(m_ADVCharaID);
                        break;
                    case "CharaPriorityReset":
                        m_ADVCharaID = func.m_value1;
                        CharaPriorityReset(m_ADVCharaID);
                        break;
                    case "CharaMot":
                        m_ADVCharaID = func.m_value1;
                        m_MotID = func.m_value2;
                        CharaMot(m_ADVCharaID, m_MotID);
                        break;
                    case "Fade":
                        m_RGBAStart = func.m_value1;
                        m_RGBAEnd = func.m_value2;
                        m_Sec = float.Parse(func.m_value3);
                        m_CurveType = int.Parse(func.m_value4);
                        Fade(m_RGBAStart, m_RGBAEnd, m_Sec, m_CurveType);
                        break;
                    case "FadeIn":
                        m_RGBA = func.m_value1;
                        m_Sec = float.Parse(func.m_value2);
                        FadeIn(m_RGBA, m_Sec);
                        break;
                    case "FadeOut":
                        m_RGBA = func.m_value1;
                        m_Sec = float.Parse(func.m_value2);
                        FadeOut(m_RGBA, m_Sec);
                        break;
                    case "Wait":
                        m_Sec = float.Parse(func.m_value1);
                        Wait(m_Sec);
                        nextCommand = false;
                        break;
                    case "WaitFade":
                        WaitFade();
                        nextCommand = false;
                        break;
                    case "WaitMotion":
                        WaitMotion();
                        nextCommand = false;
                        break;
                    case "WaitCharaMove":
                        WaitCharaMove();
                        nextCommand = false;
                        break;
                    case "WaitCharaFade":
                        WaitCharaFade();
                        nextCommand = false;
                        break;
                    case "WaitBGScroll":
                        if (func.argNum == 1)
                        {
                            m_ID = uint.Parse(func.m_value1);
                            WaitBGScroll(m_ID);
                        }
                        else { WaitBGScroll(); }
                        nextCommand = false;
                        break;
                    case "WaitBGScale":
                        if (func.argNum == 1)
                        {
                            m_ID = uint.Parse(func.m_value1);
                            WaitBGScale(m_ID);
                        }
                        else { WaitBGScale(); }
                        break;
                    case "CharaTransparency":
                        m_ADVCharaID = func.m_value1;
                        m_Alpha = uint.Parse(func.m_value2);
                        m_Sec = float.Parse(func.m_value3);
                        m_CurveType = int.Parse(func.m_value4);
                        CharaTransparency(m_ADVCharaID, m_Alpha, m_Sec, m_CurveType);
                        break;
                    case "CharaTransparencyAll":
                        m_Alpha = uint.Parse(func.m_value1);
                        m_Sec = float.Parse(func.m_value2);
                        m_CurveType = int.Parse(func.m_value3);
                        CharaTransparencyAll(m_Alpha, m_Sec, m_CurveType);
                        break;
                    case "CharaTransparencyResetAll":
                        CharaTransparencyResetAll();
                        break;
                    case "CharaRotate":
                        m_ADVCharaID = func.m_value1;
                        if (func.argNum < 6)
                        {
                            m_CharaAnchor = int.Parse(func.m_value2);
                            m_Angle = float.Parse(func.m_value3);
                            m_Sec = float.Parse(func.m_value4);
                            m_CurveType = 0;
                            if (func.argNum == 5) { m_CurveType = int.Parse(func.m_value5); }
                            CharaRotate(m_ADVCharaID, m_CharaAnchor, m_Angle, m_Sec, m_CurveType);
                        }
                        else
                        {
                            m_PivotX = float.Parse(func.m_value2);
                            m_PivotY = float.Parse(func.m_value3);
                            m_Angle = float.Parse(func.m_value4);
                            m_Sec = float.Parse(func.m_value5);
                            m_CurveType = int.Parse(func.m_value6);
                            CharaRotate(m_ADVCharaID, m_PivotX, m_PivotY, m_Angle, m_Sec, m_CurveType);
                        }
                        break;
                    case "CharaRotateReset":
                        m_ADVCharaID = func.m_value1;
                        m_Sec = float.Parse(func.m_value2);
                        CharaRotateReset(m_ADVCharaID, m_Sec);
                        break;
                    case "WaitCharaRotate":
                        if (func.argNum == 1)
                        {
                            m_ADVCharaID = func.m_value1;
                            WaitCharaRotate(m_ADVCharaID);
                        }
                        else { WaitCharaRotate(); }
                        break;
                    case "CharaAlignment":
                        m_Sec = float.Parse(func.m_value1);
                        m_CurveType = int.Parse(func.m_value2);
                        CharaAlignment(m_Sec, m_CurveType);
                        break;
                    case "CharaSwap":
                        m_ADVCharaID1 = func.m_value1;
                        m_ADVCharaID2 = func.m_value2;
                        m_Sec = float.Parse(func.m_value3);
                        m_CurveType = int.Parse(func.m_value4);
                        CharaSwap(m_ADVCharaID1, m_ADVCharaID2, m_Sec, m_CurveType);
                        break;
                    case "SetTarget":
                        m_ADVCharaID = func.m_value1;
                        m_ADVCharaID2 = func.m_value2;
                        m_ADVCharaID3 = func.m_value3;
                        m_ADVCharaID4 = func.m_value4;
                        m_ADVCharaID5 = func.m_value5;
                        SetTarget(m_ADVCharaID, m_ADVCharaID2, m_ADVCharaID3, m_ADVCharaID4, m_ADVCharaID5);
                        break;
                    case "CharaInTarget":
                        m_StartSide = int.Parse(func.m_value1);
                        m_Sec = float.Parse(func.m_value2);
                        m_CurveType = int.Parse(func.m_value3);
                        m_XOffset = 0f;
                        if (func.argNum == 4) { m_XOffset = float.Parse(func.m_value4); }
                        CharaInTarget(m_StartSide, m_Sec, m_CurveType, m_XOffset);
                        break;
                    case "CharaOutTarget":
                        m_EndSide = int.Parse(func.m_value1);
                        m_Sec = float.Parse(func.m_value2);
                        m_CurveType = int.Parse(func.m_value3);
                        CharaOutTarget(m_EndSide, m_Sec, m_CurveType);
                        break;
                    case "SpriteSet":
                        m_ID = uint.Parse(func.m_value1);
                        m_FileNameWithoutExt = func.m_value2;
                        SpriteSet(m_ID, m_FileNameWithoutExt);
                        break;
                    case "SpriteVisible":
                        m_ID = uint.Parse(func.m_value1);
                        m_VisibleFlg = uint.Parse(func.m_value2);
                        SpriteVisible(m_ID, m_VisibleFlg);
                        break;
                    case "SpriteScale":
                        m_ID = uint.Parse(func.m_value1);
                        m_X = float.Parse(func.m_value2);
                        m_Y = float.Parse(func.m_value3);
                        m_Sec = 0f;
                        if (func.argNum == 4) { m_Sec = float.Parse(func.m_value4); }
                        SpriteScale(m_ID, m_X, m_Y, m_Sec);
                        break;
                    case "SpritePos":
                        m_ID = uint.Parse(func.m_value1);
                        m_X = float.Parse(func.m_value2);
                        m_Y = float.Parse(func.m_value3);
                        m_Sec = 0f;
                        if (func.argNum == 4) { m_Sec = float.Parse(func.m_value4); }
                        SpritePos(m_ID, m_X, m_Y, m_Sec);
                        break;
                    case "SpriteFadeIn":
                        m_ID = uint.Parse(func.m_value1);
                        m_Sec = float.Parse(func.m_value2);
                        SpriteFadeIn(m_ID, m_Sec);
                        break;
                    case "SpriteFadeOut":
                        m_ID = uint.Parse(func.m_value1);
                        m_Sec = float.Parse(func.m_value2);
                        SpriteFadeOut(m_ID, m_Sec);
                        break;
                    case "SpriteColor":
                        m_ID = uint.Parse(func.m_value1);
                        m_RGBA = func.m_value2;
                        m_Sec = 0f;
                        if (func.argNum == 3) { m_Sec = float.Parse(func.m_value3); }
                        SpriteColor(m_ID, m_RGBA, m_Sec);
                        break;
                    case "WaitSpriteScale":
                        if (func.argNum == 1)
                        {
                            m_ID = uint.Parse(func.m_value1);
                            WaitSpriteScale(m_ID);
                        }
                        nextCommand = false;
                        break;
                    case "WaitSpritePos":
                        if (func.argNum == 1)
                        {
                            m_ID = uint.Parse(func.m_value1);
                            WaitSpritePos(m_ID);
                        }
                        else { WaitSpritePos(); }
                        nextCommand = false;
                        break;
                    case "WaitSpriteFade":
                        if (func.argNum == 1)
                        {
                            m_ID = uint.Parse(func.m_value1);
                            WaitSpriteFade(m_ID);
                        }
                        else { WaitSpriteFade(); }
                        nextCommand = false;
                        break;
                    case "WaitSpriteColor":
                        if (func.argNum == 1)
                        {
                            m_ID = uint.Parse(func.m_value1);
                            WaitSpriteColor(m_ID);
                        }
                        else { WaitSpriteColor(); }
                        nextCommand = false;
                        break;
                    case "PlayCaption":
                        textID = uint.Parse(func.m_value1);
                        PlayCaption(textID);
                        nextCommand = false;
                        break;
                    case "SetCaptionBGSprite":
                        fileName = func.m_value1;
                        width = float.Parse(func.m_value2);
                        height = float.Parse(func.m_value3);
                        SetCaptionBGSprite(fileName, width, height);
                        break;
                    case "SetCaptionBGStart":
                        posX = float.Parse(func.m_value1);
                        posY = float.Parse(func.m_value2);
                        sclX = float.Parse(func.m_value3);
                        sclY = float.Parse(func.m_value4);
                        rgba = func.m_value5;
                        SetCaptionBGStart(posX, posY, sclX, sclY, rgba);
                        break;
                    case "SetCaptionBGIdle":
                        posX = float.Parse(func.m_value1);
                        posY = float.Parse(func.m_value2);
                        sclX = float.Parse(func.m_value3);
                        sclY = float.Parse(func.m_value4);
                        rgba = func.m_value5;
                        SetCaptionBGIdle(posX, posY, sclX, sclY, rgba);
                        break;
                    case "SetCaptionBGEnd":
                        posX = float.Parse(func.m_value1);
                        posY = float.Parse(func.m_value2);
                        sclX = float.Parse(func.m_value3);
                        sclY = float.Parse(func.m_value4);
                        rgba = func.m_value5;
                        SetCaptionBGEnd(posX, posY, sclX, sclY, rgba);
                        break;
                    case "SetCaptionBGEaseIn":
                        sec = float.Parse(func.m_value1);
                        delay = float.Parse(func.m_value2);
                        curveType = int.Parse(func.m_value3);
                        SetCaptionBGEaseIn(sec, delay, curveType);
                        break;
                    case "SetCaptionBGEaseOut":
                        sec = float.Parse(func.m_value1);
                        delay = float.Parse(func.m_value2);
                        curveType = int.Parse(func.m_value3);
                        SetCaptionBGEaseOut(sec, delay, curveType);
                        break;
                    case "SetCaptionTextStart":
                        posX = float.Parse(func.m_value1);
                        posY = float.Parse(func.m_value2);
                        sclX = float.Parse(func.m_value3);
                        sclY = float.Parse(func.m_value4);
                        rgba = func.m_value5;
                        SetCaptionTextStart(posX, posY, sclX, sclY, rgba);
                        break;
                    case "SetCaptionTextIdle":
                        posX = float.Parse(func.m_value1);
                        posY = float.Parse(func.m_value2);
                        sclX = float.Parse(func.m_value3);
                        sclY = float.Parse(func.m_value4);
                        rgba = func.m_value5;
                        SetCaptionTextIdle(posX, posY, sclX, sclY, rgba);
                        break;
                    case "SetCaptionTextEnd":
                        posX = float.Parse(func.m_value1);
                        posY = float.Parse(func.m_value2);
                        sclX = float.Parse(func.m_value3);
                        sclY = float.Parse(func.m_value4);
                        rgba = func.m_value5;
                        SetCaptionTextEnd(posX, posY, sclX, sclY, rgba);
                        break;
                    case "SetCaptionTextEaseIn":
                        sec = float.Parse(func.m_value1);
                        delay = float.Parse(func.m_value2);
                        curveType = int.Parse(func.m_value3);
                        SetCaptionTextEaseIn(sec, delay, curveType);
                        break;
                    case "SetCaptionTextEaseOut":
                        sec = float.Parse(func.m_value1);
                        delay = float.Parse(func.m_value2);
                        curveType = int.Parse(func.m_value3);
                        SetCaptionTextEaseOut(sec, delay, curveType);
                        break;
                    case "SetCaptionDefault":
                        SetCaptionDefault();
                        break;
                    case "CharaHighlightTalker":
                        m_ADVCharaID = func.m_value1;
                        CharaHighlightTalker(m_ADVCharaID);
                        break;
                    case "CharaEmotion":
                        m_ADVCharaID = func.m_value1;
                        m_EmotionID = func.m_value2;
                        m_EmoPosition = 0;
                        if (func.argNum == 3) { m_EmoPosition = int.Parse(func.m_value3); }
                        CharaEmotion(m_ADVCharaID, m_EmotionID, m_EmoPosition);
                        break;
                    case "WaitEmotion":
                        m_ADVCharaID = func.m_value1;
                        m_EmotionID = func.m_value2;
                        WaitEmotion(m_ADVCharaID, m_EmotionID);
                        nextCommand = false;
                        break;
                    case "EmotionEnd":
                        m_ADVCharaID = func.m_value1;
                        m_EmotionID = func.m_value2;
                        EmotionEnd(m_ADVCharaID, m_EmotionID);
                        break;
                    case "CharaTalk":
                        m_TextID = uint.Parse(func.m_value1);
                        switch (func.argNum)
                        {
                            case 1:
                                m_FaceID = -1;
                                m_EmotionID = "";
                                break;
                            case 2:
                                m_FaceID = int.Parse(func.m_value2);
                                m_EmotionID = "";
                                break;
                            default:
                                m_FaceID = int.Parse(func.m_value2);
                                m_EmotionID = func.m_value3;
                                break;
                        }
                        CharaTalk(m_TextID, m_FaceID, m_EmotionID);
                        nextCommand = false;
                        break;
                    case "CharaTalkFullVoice":
                        m_TextID = uint.Parse(func.m_value1);
                        switch (func.argNum)
                        {
                            case 1:
                                m_FaceID = -1;
                                m_EmotionID = "";
                                break;
                            case 2:
                                m_FaceID = int.Parse(func.m_value2);
                                m_EmotionID = "";
                                break;
                            default:
                                m_FaceID = int.Parse(func.m_value2);
                                m_EmotionID = func.m_value3;
                                break;
                        }
                        CharaTalkFullVoice(m_TextID, m_FaceID, m_EmotionID);
                        nextCommand = false;
                        break;
                    case "CloseTalk":
                        CloseTalk();
                        break;
                    case "BGPointScale":
                        m_ID = uint.Parse(func.m_value1);
                        m_Scale = float.Parse(func.m_value2);
                        m_Sec = float.Parse(func.m_value3);
                        m_X = float.Parse(func.m_value4);
                        m_Y = float.Parse(func.m_value5);
                        m_CurveType = int.Parse(func.m_value6);
                        BGPointScale(m_ID, m_Scale, m_Sec, m_X, m_Y, m_CurveType);
                        break;
                    case "BGColor":
                        m_ID = uint.Parse(func.m_value1);
                        m_StartColor = func.m_value2;
                        m_EndColor = func.m_value3;
                        m_Sec = float.Parse(func.m_value4);
                        m_CurveType = int.Parse(func.m_value5);
                        BGColor(m_ID, m_StartColor, m_EndColor, m_Sec, m_CurveType);
                        break;
                    case "SetBGAnchor":
                        m_ID = uint.Parse(func.m_value1);
                        m_Anchor = int.Parse(func.m_value2);
                        SetBGAnchor(m_ID, m_Anchor);
                        break;
                    case "BGScroll":
                        m_ID = uint.Parse(func.m_value1);
                        m_X = float.Parse(func.m_value2);
                        m_Y = float.Parse(func.m_value3);
                        m_Sec = float.Parse(func.m_value4);
                        m_CurveType = int.Parse(func.m_value5);
                        BGScroll(m_ID, m_X, m_Y, m_Sec, m_CurveType);
                        break;
                    case "BGScale":
                        m_ID = uint.Parse(func.m_value1);
                        m_Scale = float.Parse(func.m_value2);
                        m_Sec = float.Parse(func.m_value3);
                        m_CurveType = int.Parse(func.m_value4);
                        BGScale(m_ID, m_Scale, m_Sec, m_CurveType);
                        break;
                    case "BGScrollReset":
                        m_ID = uint.Parse(func.m_value1);
                        m_Sec = float.Parse(func.m_value2);
                        m_CurveType = int.Parse(func.m_value3);
                        BGScrollReset(m_ID, m_Sec, m_CurveType);
                        break;
                    case "Shake":
                        m_ShakeType = int.Parse(func.m_value1);
                        m_Time = float.Parse(func.m_value2);
                        Shake(m_ShakeType, m_Time);
                        break;
                    case "ShakeBG":
                        m_ShakeType = int.Parse(func.m_value1);
                        m_Time = float.Parse(func.m_value2);
                        ShakeBG(m_ShakeType, m_Time);
                        break;
                    case "ShakeChara":
                        m_ShakeType = int.Parse(func.m_value1);
                        m_Time = float.Parse(func.m_value2);
                        if (func.argNum == 3)
                        {
                            m_ADVCharaID = func.m_value3;
                            ShakeChara(m_ShakeType, m_Time, m_ADVCharaID);
                        }
                        else { ShakeChara(m_ShakeType, m_Time); }
                        break;
                    case "StopShake":
                        StopShake();
                        break;
                    case "Effect":
                        m_effectID = func.m_value1;
                        m_StandPosition = int.Parse(func.m_value2);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value3);
                            m_Y = float.Parse(func.m_value4);
                            m_Rotate = float.Parse(func.m_value5);
                        }
                        Effect(m_effectID, m_StandPosition, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectChara":
                        m_effectID = func.m_value1;
                        m_ADVCharaID = func.m_value2;
                        m_CharaAnchor = int.Parse(func.m_value3);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 6)
                        {
                            m_X = float.Parse(func.m_value4);
                            m_Y = float.Parse(func.m_value5);
                            m_Rotate = float.Parse(func.m_value6);
                        }
                        EffectChara(m_effectID, m_ADVCharaID, m_CharaAnchor, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectScreen":
                        m_effectID = func.m_value1;
                        m_ScreenAnchor = int.Parse(func.m_value2);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value3);
                            m_Y = float.Parse(func.m_value4);
                            m_Rotate = float.Parse(func.m_value5);
                        }
                        EffectScreen(m_effectID, m_ScreenAnchor, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectLoop":
                        m_effectID = func.m_value1;
                        m_StandPosition = int.Parse(func.m_value2);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value3);
                            m_Y = float.Parse(func.m_value4);
                            m_Rotate = float.Parse(func.m_value5);
                        }
                        EffectLoop(m_effectID, m_StandPosition, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectCharaLoop":
                        m_effectID = func.m_value1;
                        m_ADVCharaID = func.m_value2;
                        m_CharaAnchor = int.Parse(func.m_value3);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 6)
                        {
                            m_X = float.Parse(func.m_value4);
                            m_Y = float.Parse(func.m_value5);
                            m_Rotate = float.Parse(func.m_value6);
                        }
                        EffectCharaLoop(m_effectID, m_ADVCharaID, m_CharaAnchor, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectScreenLoop":
                        m_effectID = func.m_value1;
                        m_ScreenAnchor = int.Parse(func.m_value2);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value3);
                            m_Y = float.Parse(func.m_value4);
                            m_Rotate = float.Parse(func.m_value5);
                        }
                        EffectScreenLoop(m_effectID, m_ScreenAnchor, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectLoopTarget":
                        m_effectID = func.m_value1;
                        m_afterEffectID = func.m_value2;
                        m_StandPosition = int.Parse(func.m_value3);
                        m_X = 0f;
                        m_Y = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value4);
                            m_Y = float.Parse(func.m_value5);
                        }
                        EffectLoopTarget(m_effectID, m_afterEffectID, m_StandPosition, m_X, m_Y);
                        break;
                    case "EffectCharaLoopTarget":
                        m_effectID = func.m_value1;
                        m_afterEffectID = func.m_value2;
                        m_ADVCharaID = func.m_value3;
                        m_CharaAnchor = int.Parse(func.m_value4);
                        m_X = 0f;
                        m_Y = 0f;
                        if (func.argNum == 6)
                        {
                            m_X = float.Parse(func.m_value5);
                            m_Y = float.Parse(func.m_value6);
                        }
                        EffectCharaLoopTarget(m_effectID, m_afterEffectID, m_ADVCharaID, m_CharaAnchor, m_X, m_Y);
                        break;
                    case "EffectScreenLoopTarget":
                        m_effectID = func.m_value1;
                        m_afterEffectID = func.m_value2;
                        m_ScreenAnchor = int.Parse(func.m_value3);
                        m_X = 0f;
                        m_Y = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value4);
                            m_Y = float.Parse(func.m_value5);
                        }
                        EffectScreenLoopTarget(m_effectID, m_afterEffectID, m_ScreenAnchor, m_X, m_Y);
                        break;
                    case "EffectLoopTargetEnd":
                        m_effectID = func.m_value1;
                        EffectLoopTargetEnd(m_effectID);
                        break;
                    case "EffectEnd":
                        m_effectID = func.m_value1;
                        EffectEnd(m_effectID);
                        break;
                    case "WaitEffect":
                        m_effectID = func.m_value1;
                        WaitEffect(m_effectID);
                        nextCommand = false;
                        break;
                    case "EffectMuteSE":
                        EffectMuteSE();
                        break;
                    case "EffectMuteSEReset":
                        EffectMuteSEReset();
                        break;
                    case "PresetEffectLoop":
                        m_stEffectID = func.m_value1;
                        m_lpEffectID = func.m_value2;
                        m_EdEffectID = func.m_value3;
                        m_IgnoreParticle = sbyte.Parse(func.m_value4);
                        PresetEffectLoop(m_stEffectID, m_lpEffectID, m_EdEffectID, m_IgnoreParticle);
                        break;
                    case "EffectLoopWithPreset":
                        m_StandPosition = int.Parse(func.m_value1);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 4)
                        {
                            m_X = float.Parse(func.m_value2);
                            m_Y = float.Parse(func.m_value3);
                            m_Rotate = float.Parse(func.m_value4);
                        }
                        EffectLoopWithPreset(m_StandPosition, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectCharaLoopWithPreset":
                        m_ADVCharaID = func.m_value1;
                        m_CharaAnchor = int.Parse(func.m_value2);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value3);
                            m_Y = float.Parse(func.m_value4);
                            m_Rotate = float.Parse(func.m_value5);
                        }
                        EffectCharaLoopWithPreset(m_ADVCharaID, m_CharaAnchor, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectScreenLoopWithPreset":
                        m_Anchor = int.Parse(func.m_value1);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 4)
                        {
                            m_X = float.Parse(func.m_value2);
                            m_Y = float.Parse(func.m_value3);
                            m_Rotate = float.Parse(func.m_value4);
                        }
                        EffectScreenLoopWithPreset(m_Anchor, m_X, m_Y, m_Rotate);
                        break;
                    case "Effect_CharaBehind":
                        m_effectID = func.m_value1;
                        m_StandPosition = int.Parse(func.m_value2);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value3);
                            m_Y = float.Parse(func.m_value4);
                            m_Rotate = float.Parse(func.m_value5);
                        }
                        Effect_CharaBehind(m_effectID, m_StandPosition, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectChara_CharaBehind":
                        m_effectID = func.m_value1;
                        m_ADVCharaID = func.m_value2;
                        m_CharaAnchor = int.Parse(func.m_value3);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 6)
                        {
                            m_X = float.Parse(func.m_value4);
                            m_Y = float.Parse(func.m_value5);
                            m_Rotate = float.Parse(func.m_value6);
                        }
                        EffectChara_CharaBehind(m_effectID, m_ADVCharaID, m_CharaAnchor, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectScreen_CharaBehind":
                        m_effectID = func.m_value1;
                        m_ScreenAnchor = int.Parse(func.m_value2);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value3);
                            m_Y = float.Parse(func.m_value4);
                            m_Rotate = float.Parse(func.m_value5);
                        }
                        EffectScreen_CharaBehind(m_effectID, m_ScreenAnchor, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectLoop_CharaBehind":
                        m_effectID = func.m_value1;
                        m_StandPosition = int.Parse(func.m_value2);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value3);
                            m_Y = float.Parse(func.m_value4);
                            m_Rotate = float.Parse(func.m_value5);
                        }
                        EffectLoop_CharaBehind(m_effectID, m_StandPosition, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectCharaLoop_CharaBehind":
                        m_effectID = func.m_value1;
                        m_ADVCharaID = func.m_value2;
                        m_CharaAnchor = int.Parse(func.m_value3);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 6)
                        {
                            m_X = float.Parse(func.m_value4);
                            m_Y = float.Parse(func.m_value5);
                            m_Rotate = float.Parse(func.m_value6);
                        }
                        EffectCharaLoop_CharaBehind(m_effectID, m_ADVCharaID, m_CharaAnchor, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectScreenLoop_CharaBehind":
                        m_effectID = func.m_value1;
                        m_Anchor = int.Parse(func.m_value2);
                        m_X = 0f;
                        m_Y = 0f;
                        m_Rotate = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value3);
                            m_Y = float.Parse(func.m_value4);
                            m_Rotate = float.Parse(func.m_value5);
                        }
                        EffectScreenLoop_CharaBehind(m_effectID, m_Anchor, m_X, m_Y, m_Rotate);
                        break;
                    case "EffectLoopTarget_CharaBehind":
                        m_effectID = func.m_value1;
                        m_afterEffectID = func.m_value2;
                        m_StandPosition = int.Parse(func.m_value3);
                        m_X = 0f;
                        m_Y = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value4);
                            m_Y = float.Parse(func.m_value5);
                        }
                        EffectLoopTarget_CharaBehind(m_effectID, m_afterEffectID, m_StandPosition, m_X, m_Y);
                        break;
                    case "EffectCharaLoopTarget_CharaBehind":
                        m_effectID = func.m_value1;
                        m_afterEffectID = func.m_value2;
                        m_ADVCharaID = func.m_value3;
                        m_CharaAnchor = int.Parse(func.m_value4);
                        m_X = 0f;
                        m_Y = 0f;
                        if (func.argNum == 6)
                        {
                            m_X = float.Parse(func.m_value5);
                            m_Y = float.Parse(func.m_value6);
                        }
                        EffectCharaLoopTarget_CharaBehind(m_effectID, m_afterEffectID, m_ADVCharaID, m_CharaAnchor, m_X, m_Y);
                        break;
                    case "EffectScreenLoopTarget_CharaBehind":
                        m_effectID = func.m_value1;
                        m_afterEffectID = func.m_value2;
                        m_ScreenAnchor = int.Parse(func.m_value3);
                        m_X = 0f;
                        m_Y = 0f;
                        if (func.argNum == 5)
                        {
                            m_X = float.Parse(func.m_value4);
                            m_Y = float.Parse(func.m_value5);
                        }
                        EffectScreenLoopTarget_CharaBehind(m_effectID, m_afterEffectID, m_ScreenAnchor, m_X, m_Y);
                        break;
                    case "SetPP_ColorBlendColor":
                        m_R = uint.Parse(func.m_value1);
                        m_G = uint.Parse(func.m_value2);
                        m_B = uint.Parse(func.m_value3);
                        SetPP_ColorBlendColor(m_R, m_G, m_B);
                        break;
                    case "SetPP_ColorBlendLevel":
                        m_Value = float.Parse(func.m_value1);
                        m_Sec = float.Parse(func.m_value2);
                        SetPP_ColorBlendLevel(m_Value, m_Sec);
                        break;
                    case "Enable_PP_ColorBlend":
                        m_Enable = uint.Parse(func.m_value1);
                        Enable_PP_ColorBlend(m_Enable);
                        break;
                    case "SetHDRFactor":
                        m_ADVCharaID = func.m_value1;
                        m_Value = float.Parse(func.m_value2);
                        m_Sec = float.Parse(func.m_value3);
                        SetHDRFactor(m_ADVCharaID, m_Value, m_Sec);
                        break;
                    case "SetDistorsionLevel_BG":
                        m_Value = float.Parse(func.m_value1);
                        m_Sec = float.Parse(func.m_value2);
                        SetDistorsionLevel_BG(m_Value, m_Sec);
                        break;
                    case "EnableDistorsion_BG":
                        m_Enable = uint.Parse(func.m_value1);
                        EnableDistorsion_BG(m_Enable);
                        break;
                    case "WarpPrepare":
                        m_ADVCharaID = func.m_value1;
                        m_Sec = float.Parse(func.m_value2);
                        WarpPrepare(m_ADVCharaID, m_Sec);
                        break;
                    case "WarpPrepareWait":
                        WarpPrepareWait();
                        nextCommand = false;
                        break;
                    case "WarpStart":
                        m_Sec = float.Parse(func.m_value1);
                        WarpStart(m_Sec);
                        break;
                    case "WarpWait":
                        WarpWait();
                        nextCommand = false;
                        break;
                    case "PlayBGM":
                        m_BGMCueName = func.m_value1;
                        m_FadeInSec = 0;
                        if (func.argNum == 2) { m_FadeInSec = float.Parse(func.m_value2); }
                        PlayBGM(m_BGMCueName, m_FadeInSec);
                        break;
                    case "StopBGM":
                        m_FadeOutSec = 0;
                        if (func.argNum == 1) { m_FadeOutSec = float.Parse(func.m_value1); }
                        StopBGM(m_FadeOutSec);
                        break;
                    case "PlaySE":
                        m_SeCueName = func.m_value1;
                        m_FadeInSec = 0;
                        m_FadeOutSec = 0;
                        if (func.argNum == 3)
                        {
                            m_FadeInSec = float.Parse(func.m_value2);
                            m_FadeOutSec = float.Parse(func.m_value3);
                        }
                        PlaySE(m_SeCueName, m_FadeInSec, m_FadeOutSec);
                        break;
                    case "StopSE":
                        StopSE();
                        break;
                    case "WaitSE":
                        WaitSE();
                        nextCommand = false;
                        break;
                    case "PlayVOICE":
                        m_ADVCharaID = func.m_value1;
                        m_CueName = "voice_" + func.m_value2;
                        PlayVOICECueName(m_ADVCharaID, m_CueName);
                        break;
                    case "PlayVOICECueName":
                        m_ADVCharaID = func.m_value1;
                        m_CueName = func.m_value2;
                        PlayVOICECueName(m_ADVCharaID, m_CueName);
                        break;
                    case "PlayFULLVOICE":
                        m_CueName = func.m_value1;
                        PlayFULLVOICE(m_CueName);
                        break;
                    case "WaitVOICE":
                        WaitVOICE();
                        break;
                    case "StopVOICE":
                        StopVOICE();
                        break;
                    default:
                        break;
                }
            }
            UpdateGame();
        }
    }
}
