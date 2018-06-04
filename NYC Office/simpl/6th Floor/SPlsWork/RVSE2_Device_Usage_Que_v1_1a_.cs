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

namespace UserModule_RVSE2_DEVICE_USAGE_QUE_V1_1A_
{
    public class UserModuleClass_RVSE2_DEVICE_USAGE_QUE_V1_1A_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput RV_ONLINE;
        Crestron.Logos.SplusObjects.StringInput DEVICE_USAGE__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput QUE_COUNT;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_DEVICE_USAGE__DOLLAR__;
        private void SENDUSAGEEVENTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 94;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_SplusNVRAM.G_IUSAGETEXTCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 96;
                TO_RV_DEVICE_USAGE__DOLLAR__  .UpdateValue ( _SplusNVRAM.G_SUSAGETEXT [ I ]  ) ; 
                __context__.SourceCodeLine = 94;
                } 
            
            __context__.SourceCodeLine = 99;
            _SplusNVRAM.G_IUSAGETEXTCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 100;
            QUE_COUNT  .Value = (ushort) ( _SplusNVRAM.G_IUSAGETEXTCOUNT ) ; 
            
            }
            
        private void SHIFTLIST (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 107;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 109;
                Print( "** ShiftList **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 113;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( _SplusNVRAM.G_IUSAGETEXTCOUNT ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)1; 
            int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 115;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I < 100 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 117;
                    _SplusNVRAM.G_SUSAGETEXT [ (I + 1) ]  .UpdateValue ( _SplusNVRAM.G_SUSAGETEXT [ I ]  ) ; 
                    } 
                
                __context__.SourceCodeLine = 113;
                } 
            
            
            }
            
        object RV_ONLINE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 130;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_IUSAGETEXTCOUNT > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 132;
                    SENDUSAGEEVENTS (  __context__  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DEVICE_USAGE__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            CrestronString STRASH;
            CrestronString SDATE;
            CrestronString STIME;
            STRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            SDATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            
            __context__.SourceCodeLine = 144;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 146;
                Print( "LenLogText:{0:d}\r\n", (ushort)Functions.Length( DEVICE_USAGE__DOLLAR__ )) ; 
                } 
            
            __context__.SourceCodeLine = 149;
            SDATE  .UpdateValue ( Functions.Date (  (int) ( 3 ) )  ) ; 
            __context__.SourceCodeLine = 150;
            SDATE  .UpdateValue ( Functions.Left ( SDATE ,  (int) ( 4 ) ) + "-" + Functions.Mid ( SDATE ,  (int) ( 6 ) ,  (int) ( 2 ) ) + "-" + Functions.Right ( SDATE ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 151;
            STIME  .UpdateValue ( Functions.Time ( )  ) ; 
            __context__.SourceCodeLine = 154;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_IUSAGETEXTCOUNT > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 156;
                SHIFTLIST (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 159;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_IUSAGETEXTCOUNT < 100 ))  ) ) 
                { 
                __context__.SourceCodeLine = 161;
                _SplusNVRAM.G_IUSAGETEXTCOUNT = (ushort) ( (_SplusNVRAM.G_IUSAGETEXTCOUNT + 1) ) ; 
                __context__.SourceCodeLine = 163;
                QUE_COUNT  .Value = (ushort) ( _SplusNVRAM.G_IUSAGETEXTCOUNT ) ; 
                } 
            
            __context__.SourceCodeLine = 166;
            if ( Functions.TestForTrue  ( ( Functions.Find( "USAGE" , DEVICE_USAGE__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 168;
                STRASH  .UpdateValue ( Functions.Remove ( "USAGE||-||-||" , DEVICE_USAGE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 170;
                _SplusNVRAM.G_SUSAGETEXT [ 1 ]  .UpdateValue ( "USAGE" + "||" + SDATE + "||" + STIME + "||" + DEVICE_USAGE__DOLLAR__  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 172;
                if ( Functions.TestForTrue  ( ( Functions.Find( "STAT" , DEVICE_USAGE__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 174;
                    STRASH  .UpdateValue ( Functions.Remove ( "STAT||-||-||" , DEVICE_USAGE__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 176;
                    _SplusNVRAM.G_SUSAGETEXT [ 1 ]  .UpdateValue ( "STAT" + "||" + SDATE + "||" + STIME + "||" + DEVICE_USAGE__DOLLAR__  ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 179;
            if ( Functions.TestForTrue  ( ( RV_ONLINE  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 181;
                SENDUSAGEEVENTS (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 193;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 195;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_SINITIALIZED != "YES"))  ) ) 
            { 
            __context__.SourceCodeLine = 197;
            _SplusNVRAM.G_IUSAGETEXTCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 199;
            _SplusNVRAM.G_SINITIALIZED  .UpdateValue ( "YES"  ) ; 
            } 
        
        __context__.SourceCodeLine = 202;
        QUE_COUNT  .Value = (ushort) ( _SplusNVRAM.G_IUSAGETEXTCOUNT ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.G_SINITIALIZED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    _SplusNVRAM.G_SUSAGETEXT  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        _SplusNVRAM.G_SUSAGETEXT [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    RV_ONLINE = new Crestron.Logos.SplusObjects.DigitalInput( RV_ONLINE__DigitalInput__, this );
    m_DigitalInputList.Add( RV_ONLINE__DigitalInput__, RV_ONLINE );
    
    QUE_COUNT = new Crestron.Logos.SplusObjects.AnalogOutput( QUE_COUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( QUE_COUNT__AnalogSerialOutput__, QUE_COUNT );
    
    DEVICE_USAGE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DEVICE_USAGE__DOLLAR____AnalogSerialInput__, 200, this );
    m_StringInputList.Add( DEVICE_USAGE__DOLLAR____AnalogSerialInput__, DEVICE_USAGE__DOLLAR__ );
    
    TO_RV_DEVICE_USAGE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_DEVICE_USAGE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_DEVICE_USAGE__DOLLAR____AnalogSerialOutput__, TO_RV_DEVICE_USAGE__DOLLAR__ );
    
    
    RV_ONLINE.OnDigitalPush.Add( new InputChangeHandlerWrapper( RV_ONLINE_OnPush_0, false ) );
    DEVICE_USAGE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEVICE_USAGE__DOLLAR___OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_DEVICE_USAGE_QUE_V1_1A_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint RV_ONLINE__DigitalInput__ = 1;
const uint DEVICE_USAGE__DOLLAR____AnalogSerialInput__ = 0;
const uint QUE_COUNT__AnalogSerialOutput__ = 0;
const uint TO_RV_DEVICE_USAGE__DOLLAR____AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort G_IUSAGETEXTCOUNT = 0;
            [SplusStructAttribute(1, false, true)]
            public CrestronString G_SINITIALIZED;
            [SplusStructAttribute(2, false, true)]
            public CrestronString [] G_SUSAGETEXT;
            
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
