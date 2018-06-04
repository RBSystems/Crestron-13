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

namespace UserModule_RVSE2_AUTO_UPDATE_V2_1_
{
    public class UserModuleClass_RVSE2_AUTO_UPDATE_V2_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput DEBUG_PRINT_OFFSET;
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.DigitalInput ROOMVIEW_ONLINE_FB;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_TIME_HOUR;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_TIME_MINUTE;
        Crestron.Logos.SplusObjects.AnalogInput AUTO_UPDATE_SYSTEM_HOUR;
        Crestron.Logos.SplusObjects.AnalogInput AUTO_UPDATE_PUSH_HOUR;
        Crestron.Logos.SplusObjects.AnalogInput AUTO_UPDATE_DATE_TIME_HOUR;
        Crestron.Logos.SplusObjects.DigitalOutput NEED_AUTO_UPDATE_SYSTEM_FB;
        Crestron.Logos.SplusObjects.DigitalOutput NEED_AUTO_UPDATE_PUSH_FB;
        Crestron.Logos.SplusObjects.DigitalOutput NEED_AUTO_UPDATE_DATE_TIME_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOMVIEW_ONLINE_FBD;
        Crestron.Logos.SplusObjects.StringOutput AUTO_UPDATE_SYSTEM_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AUTO_UPDATE_PUSH_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AUTO_UPDATE_DATE_TIME_TIME__DOLLAR__;
        ushort G_IRANDOMOFFSET = 0;
        ushort G_IRANDOMOFFSETRV = 0;
        ushort G_IAUTOSYSTEMHOUR = 0;
        ushort G_IAUTOPUSHHOUR = 0;
        ushort G_IAUTODATETIMEHOUR = 0;
        ushort G_IAUTOMIN = 0;
        object DEBUG_PRINT_OFFSET_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 104;
                Trace( "Auto Offset:{0:d}\r\n", (ushort)G_IRANDOMOFFSET) ; 
                __context__.SourceCodeLine = 105;
                Trace( "Auto RV Offset:{0:d}\r\n", (ushort)G_IRANDOMOFFSETRV) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object INITIALIZE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            CrestronString SSYSTEMTIME;
            CrestronString SPUSHTIME;
            CrestronString SDATETIMETIME;
            SSYSTEMTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            SPUSHTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            SDATETIMETIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            
            __context__.SourceCodeLine = 114;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 115;
                Trace( "Initialize\r\n") ; 
                }
            
            __context__.SourceCodeLine = 117;
            SSYSTEMTIME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 118;
            SPUSHTIME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 120;
            Functions.Seed (  (ushort) ( Functions.GetHSeconds() ) ) ; 
            __context__.SourceCodeLine = 122;
            G_IRANDOMOFFSET = (ushort) ( Functions.Random( (ushort)( 1 ) , (ushort)( 119 ) ) ) ; 
            __context__.SourceCodeLine = 123;
            G_IRANDOMOFFSETRV = (ushort) ( Functions.Random( (ushort)( 100 ) , (ushort)( 500 ) ) ) ; 
            __context__.SourceCodeLine = 125;
            G_IAUTOSYSTEMHOUR = (ushort) ( AUTO_UPDATE_SYSTEM_HOUR  .UshortValue ) ; 
            __context__.SourceCodeLine = 126;
            G_IAUTOPUSHHOUR = (ushort) ( AUTO_UPDATE_PUSH_HOUR  .UshortValue ) ; 
            __context__.SourceCodeLine = 127;
            G_IAUTODATETIMEHOUR = (ushort) ( AUTO_UPDATE_DATE_TIME_HOUR  .UshortValue ) ; 
            __context__.SourceCodeLine = 129;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IRANDOMOFFSET > 59 ))  ) ) 
                { 
                __context__.SourceCodeLine = 131;
                G_IAUTOSYSTEMHOUR = (ushort) ( (G_IAUTOSYSTEMHOUR + 1) ) ; 
                __context__.SourceCodeLine = 133;
                G_IAUTOPUSHHOUR = (ushort) ( (G_IAUTOPUSHHOUR + 1) ) ; 
                __context__.SourceCodeLine = 135;
                G_IAUTODATETIMEHOUR = (ushort) ( (G_IAUTODATETIMEHOUR + 1) ) ; 
                __context__.SourceCodeLine = 137;
                G_IAUTOMIN = (ushort) ( (G_IRANDOMOFFSET - 60) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 141;
                G_IAUTOMIN = (ushort) ( G_IRANDOMOFFSET ) ; 
                } 
            
            __context__.SourceCodeLine = 144;
            SSYSTEMTIME  .UpdateValue ( Functions.ItoA (  (int) ( G_IAUTOSYSTEMHOUR ) )  ) ; 
            __context__.SourceCodeLine = 145;
            SPUSHTIME  .UpdateValue ( Functions.ItoA (  (int) ( G_IAUTOPUSHHOUR ) )  ) ; 
            __context__.SourceCodeLine = 146;
            SDATETIMETIME  .UpdateValue ( Functions.ItoA (  (int) ( G_IAUTODATETIMEHOUR ) )  ) ; 
            __context__.SourceCodeLine = 148;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IAUTOMIN < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 150;
                AUTO_UPDATE_SYSTEM_TIME__DOLLAR__  .UpdateValue ( SSYSTEMTIME + ":" + "0" + Functions.ItoA (  (int) ( G_IAUTOMIN ) )  ) ; 
                __context__.SourceCodeLine = 151;
                AUTO_UPDATE_PUSH_TIME__DOLLAR__  .UpdateValue ( SPUSHTIME + ":" + "0" + Functions.ItoA (  (int) ( G_IAUTOMIN ) )  ) ; 
                __context__.SourceCodeLine = 152;
                AUTO_UPDATE_DATE_TIME_TIME__DOLLAR__  .UpdateValue ( SDATETIMETIME + ":" + "0" + Functions.ItoA (  (int) ( G_IAUTOMIN ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 156;
                AUTO_UPDATE_SYSTEM_TIME__DOLLAR__  .UpdateValue ( SSYSTEMTIME + ":" + Functions.ItoA (  (int) ( G_IAUTOMIN ) )  ) ; 
                __context__.SourceCodeLine = 157;
                AUTO_UPDATE_PUSH_TIME__DOLLAR__  .UpdateValue ( SPUSHTIME + ":" + Functions.ItoA (  (int) ( G_IAUTOMIN ) )  ) ; 
                __context__.SourceCodeLine = 158;
                AUTO_UPDATE_DATE_TIME_TIME__DOLLAR__  .UpdateValue ( SDATETIMETIME + ":" + Functions.ItoA (  (int) ( G_IAUTOMIN ) )  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ROOMVIEW_ONLINE_FB_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 164;
        CreateWait ( "ROOMVIEWDELAY" , G_IRANDOMOFFSETRV , ROOMVIEWDELAY_Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void ROOMVIEWDELAY_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 166;
            ROOMVIEW_ONLINE_FBD  .Value = (ushort) ( 1 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object ROOMVIEW_ONLINE_FB_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 172;
        CancelWait ( "ROOMVIEWDELAY" ) ; 
        __context__.SourceCodeLine = 174;
        ROOMVIEW_ONLINE_FBD  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CURRENT_TIME_MINUTE_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 180;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CURRENT_TIME_HOUR  .UshortValue == G_IAUTOSYSTEMHOUR) ) && Functions.TestForTrue ( Functions.BoolToInt (CURRENT_TIME_MINUTE  .UshortValue == G_IAUTOMIN) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 183;
            NEED_AUTO_UPDATE_SYSTEM_FB  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 187;
            NEED_AUTO_UPDATE_SYSTEM_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 190;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CURRENT_TIME_HOUR  .UshortValue == G_IAUTOPUSHHOUR) ) && Functions.TestForTrue ( Functions.BoolToInt (CURRENT_TIME_MINUTE  .UshortValue == G_IAUTOMIN) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 193;
            NEED_AUTO_UPDATE_PUSH_FB  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 197;
            NEED_AUTO_UPDATE_PUSH_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 200;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CURRENT_TIME_HOUR  .UshortValue == G_IAUTODATETIMEHOUR) ) && Functions.TestForTrue ( Functions.BoolToInt (CURRENT_TIME_MINUTE  .UshortValue == G_IAUTOMIN) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 203;
            NEED_AUTO_UPDATE_DATE_TIME_FB  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 207;
            NEED_AUTO_UPDATE_DATE_TIME_FB  .Value = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 219;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 221;
        AUTO_UPDATE_SYSTEM_TIME__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 222;
        AUTO_UPDATE_PUSH_TIME__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 223;
        AUTO_UPDATE_DATE_TIME_TIME__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    DEBUG_PRINT_OFFSET = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG_PRINT_OFFSET__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG_PRINT_OFFSET__DigitalInput__, DEBUG_PRINT_OFFSET );
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    ROOMVIEW_ONLINE_FB = new Crestron.Logos.SplusObjects.DigitalInput( ROOMVIEW_ONLINE_FB__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMVIEW_ONLINE_FB__DigitalInput__, ROOMVIEW_ONLINE_FB );
    
    NEED_AUTO_UPDATE_SYSTEM_FB = new Crestron.Logos.SplusObjects.DigitalOutput( NEED_AUTO_UPDATE_SYSTEM_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( NEED_AUTO_UPDATE_SYSTEM_FB__DigitalOutput__, NEED_AUTO_UPDATE_SYSTEM_FB );
    
    NEED_AUTO_UPDATE_PUSH_FB = new Crestron.Logos.SplusObjects.DigitalOutput( NEED_AUTO_UPDATE_PUSH_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( NEED_AUTO_UPDATE_PUSH_FB__DigitalOutput__, NEED_AUTO_UPDATE_PUSH_FB );
    
    NEED_AUTO_UPDATE_DATE_TIME_FB = new Crestron.Logos.SplusObjects.DigitalOutput( NEED_AUTO_UPDATE_DATE_TIME_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( NEED_AUTO_UPDATE_DATE_TIME_FB__DigitalOutput__, NEED_AUTO_UPDATE_DATE_TIME_FB );
    
    ROOMVIEW_ONLINE_FBD = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMVIEW_ONLINE_FBD__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOMVIEW_ONLINE_FBD__DigitalOutput__, ROOMVIEW_ONLINE_FBD );
    
    CURRENT_TIME_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_TIME_HOUR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_TIME_HOUR__AnalogSerialInput__, CURRENT_TIME_HOUR );
    
    CURRENT_TIME_MINUTE = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_TIME_MINUTE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_TIME_MINUTE__AnalogSerialInput__, CURRENT_TIME_MINUTE );
    
    AUTO_UPDATE_SYSTEM_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( AUTO_UPDATE_SYSTEM_HOUR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AUTO_UPDATE_SYSTEM_HOUR__AnalogSerialInput__, AUTO_UPDATE_SYSTEM_HOUR );
    
    AUTO_UPDATE_PUSH_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( AUTO_UPDATE_PUSH_HOUR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AUTO_UPDATE_PUSH_HOUR__AnalogSerialInput__, AUTO_UPDATE_PUSH_HOUR );
    
    AUTO_UPDATE_DATE_TIME_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( AUTO_UPDATE_DATE_TIME_HOUR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AUTO_UPDATE_DATE_TIME_HOUR__AnalogSerialInput__, AUTO_UPDATE_DATE_TIME_HOUR );
    
    AUTO_UPDATE_SYSTEM_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AUTO_UPDATE_SYSTEM_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUTO_UPDATE_SYSTEM_TIME__DOLLAR____AnalogSerialOutput__, AUTO_UPDATE_SYSTEM_TIME__DOLLAR__ );
    
    AUTO_UPDATE_PUSH_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AUTO_UPDATE_PUSH_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUTO_UPDATE_PUSH_TIME__DOLLAR____AnalogSerialOutput__, AUTO_UPDATE_PUSH_TIME__DOLLAR__ );
    
    AUTO_UPDATE_DATE_TIME_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AUTO_UPDATE_DATE_TIME_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUTO_UPDATE_DATE_TIME_TIME__DOLLAR____AnalogSerialOutput__, AUTO_UPDATE_DATE_TIME_TIME__DOLLAR__ );
    
    ROOMVIEWDELAY_Callback = new WaitFunction( ROOMVIEWDELAY_CallbackFn );
    
    DEBUG_PRINT_OFFSET.OnDigitalPush.Add( new InputChangeHandlerWrapper( DEBUG_PRINT_OFFSET_OnPush_0, false ) );
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_1, false ) );
    ROOMVIEW_ONLINE_FB.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOMVIEW_ONLINE_FB_OnPush_2, false ) );
    ROOMVIEW_ONLINE_FB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ROOMVIEW_ONLINE_FB_OnRelease_3, false ) );
    CURRENT_TIME_MINUTE.OnAnalogChange.Add( new InputChangeHandlerWrapper( CURRENT_TIME_MINUTE_OnChange_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_AUTO_UPDATE_V2_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction ROOMVIEWDELAY_Callback;


const uint DEBUG__DigitalInput__ = 0;
const uint DEBUG_PRINT_OFFSET__DigitalInput__ = 1;
const uint INITIALIZE__DigitalInput__ = 2;
const uint ROOMVIEW_ONLINE_FB__DigitalInput__ = 3;
const uint CURRENT_TIME_HOUR__AnalogSerialInput__ = 0;
const uint CURRENT_TIME_MINUTE__AnalogSerialInput__ = 1;
const uint AUTO_UPDATE_SYSTEM_HOUR__AnalogSerialInput__ = 2;
const uint AUTO_UPDATE_PUSH_HOUR__AnalogSerialInput__ = 3;
const uint AUTO_UPDATE_DATE_TIME_HOUR__AnalogSerialInput__ = 4;
const uint NEED_AUTO_UPDATE_SYSTEM_FB__DigitalOutput__ = 0;
const uint NEED_AUTO_UPDATE_PUSH_FB__DigitalOutput__ = 1;
const uint NEED_AUTO_UPDATE_DATE_TIME_FB__DigitalOutput__ = 2;
const uint ROOMVIEW_ONLINE_FBD__DigitalOutput__ = 3;
const uint AUTO_UPDATE_SYSTEM_TIME__DOLLAR____AnalogSerialOutput__ = 0;
const uint AUTO_UPDATE_PUSH_TIME__DOLLAR____AnalogSerialOutput__ = 1;
const uint AUTO_UPDATE_DATE_TIME_TIME__DOLLAR____AnalogSerialOutput__ = 2;

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
