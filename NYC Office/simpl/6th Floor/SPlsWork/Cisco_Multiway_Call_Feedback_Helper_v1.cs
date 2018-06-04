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

namespace UserModule_CISCO_MULTIWAY_CALL_FEEDBACK_HELPER_V1
{
    public class UserModuleClass_CISCO_MULTIWAY_CALL_FEEDBACK_HELPER_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL_B;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> CALL_CONNECTED_HELD;
        Crestron.Logos.SplusObjects.BufferInput CISCO_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput POLL_BUSY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput MULTISITE_CALL_CONNECTED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput MULTIWAY_CALL_CONNECTED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SINGLE_CALL_CONNECTED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput NO_CALL_CONNECTED_FB;
        Crestron.Logos.SplusObjects.StringOutput CISCO_TX__DOLLAR__;
        UShortParameter DEBUGMODE;
        ushort G_NSEMAPHORE = 0;
        ushort G_NSTARTPOS = 0;
        ushort G_NENDPOS = 0;
        ushort G_NDEBUG = 0;
        ushort G_NCALLCONNECTED = 0;
        CrestronString G_SCURRENTMULTIPOINTMODE__DOLLAR__;
        CrestronString G_STEMP__DOLLAR__;
        CrestronString G_SGARBAGE__DOLLAR__;
        private void UPDATEOUTPUTS (  SplusExecutionContext __context__, CrestronString SCURRENT_MODE__DOLLAR__ ) 
            { 
            
            __context__.SourceCodeLine = 59;
            if ( Functions.TestForTrue  ( ( G_NCALLCONNECTED)  ) ) 
                { 
                __context__.SourceCodeLine = 61;
                if ( Functions.TestForTrue  ( ( Functions.Find( Functions.Upper( "MultiSite" ) , Functions.Upper( SCURRENT_MODE__DOLLAR__ ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 63;
                    NO_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 64;
                    MULTIWAY_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 65;
                    SINGLE_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 66;
                    MULTISITE_CALL_CONNECTED_FB  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 68;
                    if ( Functions.TestForTrue  ( ( Functions.Find( Functions.Upper( "MultiWay" ) , Functions.Upper( SCURRENT_MODE__DOLLAR__ ) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 70;
                        NO_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 71;
                        MULTISITE_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 72;
                        SINGLE_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 73;
                        MULTIWAY_CALL_CONNECTED_FB  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 75;
                        if ( Functions.TestForTrue  ( ( Functions.Find( Functions.Upper( "Off" ) , Functions.Upper( SCURRENT_MODE__DOLLAR__ ) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 77;
                            NO_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 78;
                            MULTISITE_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 79;
                            MULTIWAY_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 80;
                            SINGLE_CALL_CONNECTED_FB  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        }
                    
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 85;
                MULTISITE_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 86;
                MULTIWAY_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 87;
                SINGLE_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 88;
                NO_CALL_CONNECTED_FB  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            }
            
        object POLL_B_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 97;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( POLL_BUSY_FB  .Value ) ) && Functions.TestForTrue ( G_NCALLCONNECTED )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 99;
                    POLL_BUSY_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 100;
                    MakeString ( CISCO_TX__DOLLAR__ , "{0}", "xStatus Conference Multipoint Mode\r\n" ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CALL_CONNECTED_HELD_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 106;
            G_NCALLCONNECTED = (ushort) ( 1 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CALL_CONNECTED_HELD_OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NLASTCALL = 0;
        ushort NTEMPCALLSTATUS = 0;
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 113;
        NTEMPCALLSTATUS = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 115;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)3; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 117;
            if ( Functions.TestForTrue  ( ( CALL_CONNECTED_HELD[ I ] .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 119;
                NTEMPCALLSTATUS = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 115;
            } 
        
        __context__.SourceCodeLine = 123;
        G_NCALLCONNECTED = (ushort) ( NTEMPCALLSTATUS ) ; 
        __context__.SourceCodeLine = 125;
        if ( Functions.TestForTrue  ( ( Functions.Not( G_NCALLCONNECTED ))  ) ) 
            { 
            __context__.SourceCodeLine = 127;
            MULTISITE_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 128;
            MULTIWAY_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 129;
            SINGLE_CALL_CONNECTED_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 130;
            NO_CALL_CONNECTED_FB  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CISCO_RX__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 136;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( G_NSEMAPHORE ) ) && Functions.TestForTrue ( POLL_BUSY_FB  .Value )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 138;
            G_NSEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 139;
            while ( Functions.TestForTrue  ( ( Functions.Find( "\u000D\u000A" , CISCO_RX__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 141;
                G_STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , CISCO_RX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 143;
                if ( Functions.TestForTrue  ( ( Functions.Find( "*s Conference Multipoint Mode: \u0022" , G_STEMP__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 145;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 145;
                        Print( "Multimode Section Found\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 146;
                    G_NSTARTPOS = (ushort) ( (Functions.Find( "*s Conference Multipoint Mode: \u0022" , G_STEMP__DOLLAR__ ) + Functions.Length( "*s Conference Multipoint Mode: \u0022" )) ) ; 
                    __context__.SourceCodeLine = 147;
                    G_NENDPOS = (ushort) ( Functions.Find( "\u0022" , G_STEMP__DOLLAR__ , G_NSTARTPOS ) ) ; 
                    __context__.SourceCodeLine = 148;
                    MakeString ( G_SCURRENTMULTIPOINTMODE__DOLLAR__ , "{0}", Functions.Mid ( G_STEMP__DOLLAR__ ,  (int) ( G_NSTARTPOS ) ,  (int) ( (G_NENDPOS - G_NSTARTPOS) ) ) ) ; 
                    __context__.SourceCodeLine = 149;
                    UPDATEOUTPUTS (  __context__ , G_SCURRENTMULTIPOINTMODE__DOLLAR__) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 151;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "** end" , G_STEMP__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 153;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 153;
                            Print( "End of Section Found\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 154;
                        Functions.ClearBuffer ( CISCO_RX__DOLLAR__ ) ; 
                        __context__.SourceCodeLine = 155;
                        POLL_BUSY_FB  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 159;
                        G_SGARBAGE__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , CISCO_RX__DOLLAR__ )  ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 139;
                } 
            
            __context__.SourceCodeLine = 162;
            G_NSEMAPHORE = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 166;
            Functions.ClearBuffer ( CISCO_RX__DOLLAR__ ) ; 
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
        
        __context__.SourceCodeLine = 175;
        MakeString ( G_STEMP__DOLLAR__ , "") ; 
        __context__.SourceCodeLine = 176;
        MakeString ( G_SGARBAGE__DOLLAR__ , "") ; 
        __context__.SourceCodeLine = 177;
        MakeString ( G_SCURRENTMULTIPOINTMODE__DOLLAR__ , "") ; 
        __context__.SourceCodeLine = 178;
        G_NSTARTPOS = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 179;
        G_NENDPOS = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 180;
        G_NSEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 181;
        G_NCALLCONNECTED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 182;
        G_NDEBUG = (ushort) ( DEBUGMODE  .Value ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SCURRENTMULTIPOINTMODE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    G_STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    G_SGARBAGE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    POLL_B = new Crestron.Logos.SplusObjects.DigitalInput( POLL_B__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_B__DigitalInput__, POLL_B );
    
    CALL_CONNECTED_HELD = new InOutArray<DigitalInput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        CALL_CONNECTED_HELD[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( CALL_CONNECTED_HELD__DigitalInput__ + i, CALL_CONNECTED_HELD__DigitalInput__, this );
        m_DigitalInputList.Add( CALL_CONNECTED_HELD__DigitalInput__ + i, CALL_CONNECTED_HELD[i+1] );
    }
    
    POLL_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( POLL_BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( POLL_BUSY_FB__DigitalOutput__, POLL_BUSY_FB );
    
    MULTISITE_CALL_CONNECTED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MULTISITE_CALL_CONNECTED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MULTISITE_CALL_CONNECTED_FB__DigitalOutput__, MULTISITE_CALL_CONNECTED_FB );
    
    MULTIWAY_CALL_CONNECTED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MULTIWAY_CALL_CONNECTED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MULTIWAY_CALL_CONNECTED_FB__DigitalOutput__, MULTIWAY_CALL_CONNECTED_FB );
    
    SINGLE_CALL_CONNECTED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SINGLE_CALL_CONNECTED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SINGLE_CALL_CONNECTED_FB__DigitalOutput__, SINGLE_CALL_CONNECTED_FB );
    
    NO_CALL_CONNECTED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( NO_CALL_CONNECTED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( NO_CALL_CONNECTED_FB__DigitalOutput__, NO_CALL_CONNECTED_FB );
    
    CISCO_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CISCO_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CISCO_TX__DOLLAR____AnalogSerialOutput__, CISCO_TX__DOLLAR__ );
    
    CISCO_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( CISCO_RX__DOLLAR____AnalogSerialInput__, 5000, this );
    m_StringInputList.Add( CISCO_RX__DOLLAR____AnalogSerialInput__, CISCO_RX__DOLLAR__ );
    
    DEBUGMODE = new UShortParameter( DEBUGMODE__Parameter__, this );
    m_ParameterList.Add( DEBUGMODE__Parameter__, DEBUGMODE );
    
    
    POLL_B.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_B_OnPush_0, false ) );
    for( uint i = 0; i < 3; i++ )
        CALL_CONNECTED_HELD[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( CALL_CONNECTED_HELD_OnPush_1, false ) );
        
    for( uint i = 0; i < 3; i++ )
        CALL_CONNECTED_HELD[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( CALL_CONNECTED_HELD_OnRelease_2, false ) );
        
    CISCO_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( CISCO_RX__DOLLAR___OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CISCO_MULTIWAY_CALL_FEEDBACK_HELPER_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL_B__DigitalInput__ = 0;
const uint CALL_CONNECTED_HELD__DigitalInput__ = 1;
const uint CISCO_RX__DOLLAR____AnalogSerialInput__ = 0;
const uint POLL_BUSY_FB__DigitalOutput__ = 0;
const uint MULTISITE_CALL_CONNECTED_FB__DigitalOutput__ = 1;
const uint MULTIWAY_CALL_CONNECTED_FB__DigitalOutput__ = 2;
const uint SINGLE_CALL_CONNECTED_FB__DigitalOutput__ = 3;
const uint NO_CALL_CONNECTED_FB__DigitalOutput__ = 4;
const uint CISCO_TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint DEBUGMODE__Parameter__ = 10;

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
