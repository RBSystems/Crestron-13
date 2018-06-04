using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_RVSE_CALL_STAT_V2_1_
{
    public class UserModuleClass_RVSE_CALL_STAT_V2_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_LOG_ON_ID_CHANGE;
        Crestron.Logos.SplusObjects.DigitalInput RV_ONLINE;
        Crestron.Logos.SplusObjects.DigitalInput CLOCK;
        Crestron.Logos.SplusObjects.DigitalInput ASSET_OFFHOOK_FB;
        Crestron.Logos.SplusObjects.AnalogInput MIN_SUCCESS_TIME_SEC;
        Crestron.Logos.SplusObjects.StringInput MEETING_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput ASSET_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput ASSET_TYPE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput ASSET_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput CALL_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput LAST_CALL_MINUTES;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_DEVICE_USAGE__DOLLAR__;
        ushort G_ILASTUSEDMINUTES = 0;
        ushort G_ILASTUSEDSECONDS = 0;
        ushort G_IMODE = 0;
        CrestronString G_SLASTMEETINGID;
        private void OUTPUTLASTUSED (  SplusExecutionContext __context__, ushort TYPE ) 
            { 
            CrestronString SCALLSTATUS;
            SCALLSTATUS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            CrestronString SASSETID;
            CrestronString SMEETINGID;
            SASSETID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            ushort ILASTCALLTOTALSECONDS = 0;
            
            
            __context__.SourceCodeLine = 106;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 108;
                Print( "** OutputLastUsed **\r\n") ; 
                __context__.SourceCodeLine = 109;
                Print( "    Type:{0:d}\r\n", (ushort)TYPE) ; 
                } 
            
            __context__.SourceCodeLine = 112;
            SCALLSTATUS  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 116;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( ASSET_ID__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 118;
                SASSETID  .UpdateValue ( ASSET_ID__DOLLAR__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 122;
                SASSETID  .UpdateValue ( "-"  ) ; 
                } 
            
            __context__.SourceCodeLine = 125;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 129;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( MEETING_ID__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 131;
                    SMEETINGID  .UpdateValue ( MEETING_ID__DOLLAR__  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 135;
                    SMEETINGID  .UpdateValue ( "-"  ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 138;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 142;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_SLASTMEETINGID ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 144;
                        SMEETINGID  .UpdateValue ( G_SLASTMEETINGID  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 148;
                        SMEETINGID  .UpdateValue ( "-"  ) ; 
                        } 
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 153;
            ILASTCALLTOTALSECONDS = (ushort) ( ((G_ILASTUSEDMINUTES * 60) + G_ILASTUSEDSECONDS) ) ; 
            __context__.SourceCodeLine = 156;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILASTCALLTOTALSECONDS >= MIN_SUCCESS_TIME_SEC  .UshortValue ))  ) ) 
                { 
                __context__.SourceCodeLine = 159;
                SCALLSTATUS  .UpdateValue ( "Success"  ) ; 
                __context__.SourceCodeLine = 162;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ILASTUSEDMINUTES == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 163;
                    G_ILASTUSEDMINUTES = (ushort) ( 1 ) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 168;
                SCALLSTATUS  .UpdateValue ( "Failed"  ) ; 
                __context__.SourceCodeLine = 169;
                G_ILASTUSEDMINUTES = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 172;
            LAST_CALL_MINUTES  .Value = (ushort) ( G_ILASTUSEDMINUTES ) ; 
            __context__.SourceCodeLine = 175;
            MakeString ( TO_RV_DEVICE_USAGE__DOLLAR__ , "STAT||-||-||CALL||{0}||{1}||{2}||{3}||{4}||{5}||{6}||", ASSET_TYPE__DOLLAR__ , ASSET_NAME__DOLLAR__ , CALL_NUMBER__DOLLAR__ , Functions.ItoA (  (int) ( G_ILASTUSEDMINUTES ) ) , SCALLSTATUS , SASSETID , SMEETINGID ) ; 
            
            }
            
        object MEETING_ID__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 186;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 187;
                    Print( "* Meeting ID Change *\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 189;
                if ( Functions.TestForTrue  ( ( ENABLE_LOG_ON_ID_CHANGE  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 192;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETING_ID__DOLLAR__ != G_SLASTMEETINGID))  ) ) 
                        { 
                        __context__.SourceCodeLine = 197;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IMODE == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 202;
                            OUTPUTLASTUSED (  __context__ , (ushort)( 2 )) ; 
                            __context__.SourceCodeLine = 205;
                            G_ILASTUSEDMINUTES = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 206;
                            G_ILASTUSEDSECONDS = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 211;
                G_SLASTMEETINGID  .UpdateValue ( MEETING_ID__DOLLAR__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ASSET_OFFHOOK_FB_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 217;
            G_ILASTUSEDMINUTES = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 218;
            G_ILASTUSEDSECONDS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 220;
            G_IMODE = (ushort) ( 1 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ASSET_OFFHOOK_FB_OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 225;
        G_IMODE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 227;
        OUTPUTLASTUSED (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLOCK_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 234;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IMODE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 236;
            G_ILASTUSEDSECONDS = (ushort) ( (G_ILASTUSEDSECONDS + 10) ) ; 
            __context__.SourceCodeLine = 238;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ILASTUSEDSECONDS > 59 ))  ) ) 
                { 
                __context__.SourceCodeLine = 240;
                G_ILASTUSEDMINUTES = (ushort) ( (G_ILASTUSEDMINUTES + 1) ) ; 
                __context__.SourceCodeLine = 241;
                G_ILASTUSEDSECONDS = (ushort) ( (G_ILASTUSEDSECONDS - 60) ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 254;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 256;
        G_IMODE = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SLASTMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    ENABLE_LOG_ON_ID_CHANGE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_LOG_ON_ID_CHANGE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_LOG_ON_ID_CHANGE__DigitalInput__, ENABLE_LOG_ON_ID_CHANGE );
    
    RV_ONLINE = new Crestron.Logos.SplusObjects.DigitalInput( RV_ONLINE__DigitalInput__, this );
    m_DigitalInputList.Add( RV_ONLINE__DigitalInput__, RV_ONLINE );
    
    CLOCK = new Crestron.Logos.SplusObjects.DigitalInput( CLOCK__DigitalInput__, this );
    m_DigitalInputList.Add( CLOCK__DigitalInput__, CLOCK );
    
    ASSET_OFFHOOK_FB = new Crestron.Logos.SplusObjects.DigitalInput( ASSET_OFFHOOK_FB__DigitalInput__, this );
    m_DigitalInputList.Add( ASSET_OFFHOOK_FB__DigitalInput__, ASSET_OFFHOOK_FB );
    
    MIN_SUCCESS_TIME_SEC = new Crestron.Logos.SplusObjects.AnalogInput( MIN_SUCCESS_TIME_SEC__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MIN_SUCCESS_TIME_SEC__AnalogSerialInput__, MIN_SUCCESS_TIME_SEC );
    
    LAST_CALL_MINUTES = new Crestron.Logos.SplusObjects.AnalogOutput( LAST_CALL_MINUTES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LAST_CALL_MINUTES__AnalogSerialOutput__, LAST_CALL_MINUTES );
    
    MEETING_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( MEETING_ID__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( MEETING_ID__DOLLAR____AnalogSerialInput__, MEETING_ID__DOLLAR__ );
    
    ASSET_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ASSET_ID__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( ASSET_ID__DOLLAR____AnalogSerialInput__, ASSET_ID__DOLLAR__ );
    
    ASSET_TYPE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ASSET_TYPE__DOLLAR____AnalogSerialInput__, 25, this );
    m_StringInputList.Add( ASSET_TYPE__DOLLAR____AnalogSerialInput__, ASSET_TYPE__DOLLAR__ );
    
    ASSET_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ASSET_NAME__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( ASSET_NAME__DOLLAR____AnalogSerialInput__, ASSET_NAME__DOLLAR__ );
    
    CALL_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( CALL_NUMBER__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( CALL_NUMBER__DOLLAR____AnalogSerialInput__, CALL_NUMBER__DOLLAR__ );
    
    TO_RV_DEVICE_USAGE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_DEVICE_USAGE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_DEVICE_USAGE__DOLLAR____AnalogSerialOutput__, TO_RV_DEVICE_USAGE__DOLLAR__ );
    
    
    MEETING_ID__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( MEETING_ID__DOLLAR___OnChange_0, false ) );
    ASSET_OFFHOOK_FB.OnDigitalPush.Add( new InputChangeHandlerWrapper( ASSET_OFFHOOK_FB_OnPush_1, false ) );
    ASSET_OFFHOOK_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ASSET_OFFHOOK_FB_OnRelease_2, false ) );
    CLOCK.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLOCK_OnPush_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE_CALL_STAT_V2_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint ENABLE_LOG_ON_ID_CHANGE__DigitalInput__ = 1;
const uint RV_ONLINE__DigitalInput__ = 2;
const uint CLOCK__DigitalInput__ = 3;
const uint ASSET_OFFHOOK_FB__DigitalInput__ = 4;
const uint MIN_SUCCESS_TIME_SEC__AnalogSerialInput__ = 0;
const uint MEETING_ID__DOLLAR____AnalogSerialInput__ = 1;
const uint ASSET_ID__DOLLAR____AnalogSerialInput__ = 2;
const uint ASSET_TYPE__DOLLAR____AnalogSerialInput__ = 3;
const uint ASSET_NAME__DOLLAR____AnalogSerialInput__ = 4;
const uint CALL_NUMBER__DOLLAR____AnalogSerialInput__ = 5;
const uint LAST_CALL_MINUTES__AnalogSerialOutput__ = 0;
const uint TO_RV_DEVICE_USAGE__DOLLAR____AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
