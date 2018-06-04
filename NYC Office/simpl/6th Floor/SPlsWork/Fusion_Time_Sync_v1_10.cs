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

namespace UserModule_FUSION_TIME_SYNC_V1_10
{
    public class UserModuleClass_FUSION_TIME_SYNC_V1_10 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SYNC_TIME_B;
        Crestron.Logos.SplusObjects.StringInput LOCAL_DATE_TIME_QUERY_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput LOCAL_DATE_TIME_QUERY_TX__DOLLAR__;
        UShortParameter INSTANCEID;
        ushort G_NSEMAPHORE = 0;
        object SYNC_TIME_B_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 35;
                Functions.Seed (  (ushort) ( Functions.GetTicks() ) ) ; 
                __context__.SourceCodeLine = 36;
                Functions.Delay (  (int) ( (Mod( (Functions.Random( (ushort)( 0 ) , (ushort)( 60 ) ) + INSTANCEID  .Value) , 60 ) * 1000) ) ) ; 
                __context__.SourceCodeLine = 37;
                MakeString ( LOCAL_DATE_TIME_QUERY_TX__DOLLAR__ , "<LocalTimeRequest><RequestID>{0}</RequestID></LocalTimeRequest>", Functions.ItoA (  (int) ( Functions.Random( (ushort)( 0 ) , (ushort)( 255 ) ) ) ) ) ; 
                __context__.SourceCodeLine = 38;
                MakeString ( LOCAL_DATE_TIME_QUERY_TX__DOLLAR__ , "") ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object LOCAL_DATE_TIME_QUERY_RX__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            CrestronString STEMP_STRING;
            STEMP_STRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            CrestronString STEMP_STRING2;
            STEMP_STRING2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            ushort NSYNC_YEAR = 0;
            ushort NSYNC_MONTH = 0;
            ushort NSYNC_DATE = 0;
            ushort NSYNC_HOUR = 0;
            ushort NSYNC_MINUTE = 0;
            ushort NSYNC_SECOND = 0;
            
            ushort NPOS1 = 0;
            ushort NPOS2 = 0;
            
            
            __context__.SourceCodeLine = 49;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_NSEMAPHORE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 51;
                G_NSEMAPHORE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 53;
                STEMP_STRING  .UpdateValue ( Functions.Gather ( "</LocalTimeResponse>" , LOCAL_DATE_TIME_QUERY_RX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 54;
                NPOS1 = (ushort) ( (Functions.Find( "<LocalDateTime>" , STEMP_STRING , 1 ) + Functions.Length( "<LocalDateTime>" )) ) ; 
                __context__.SourceCodeLine = 55;
                NPOS2 = (ushort) ( Functions.Find( "</LocalDateTime>" , STEMP_STRING , NPOS1 ) ) ; 
                __context__.SourceCodeLine = 57;
                STEMP_STRING2  .UpdateValue ( Functions.Mid ( STEMP_STRING ,  (int) ( NPOS1 ) ,  (int) ( (NPOS2 - NPOS1) ) )  ) ; 
                __context__.SourceCodeLine = 58;
                NSYNC_YEAR = (ushort) ( Functions.Atoi( Functions.Mid( STEMP_STRING2 , (int)( 1 ) , (int)( 4 ) ) ) ) ; 
                __context__.SourceCodeLine = 59;
                NSYNC_MONTH = (ushort) ( Functions.Atoi( Functions.Mid( STEMP_STRING2 , (int)( 6 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 60;
                NSYNC_DATE = (ushort) ( Functions.Atoi( Functions.Mid( STEMP_STRING2 , (int)( 9 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 61;
                NSYNC_HOUR = (ushort) ( Functions.Atoi( Functions.Mid( STEMP_STRING2 , (int)( 12 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 62;
                NSYNC_MINUTE = (ushort) ( Functions.Atoi( Functions.Mid( STEMP_STRING2 , (int)( 15 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 63;
                NSYNC_SECOND = (ushort) ( Functions.Atoi( Functions.Mid( STEMP_STRING2 , (int)( 18 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 65;
                Functions.SetClock (  (int) ( NSYNC_HOUR ) ,  (int) ( NSYNC_MINUTE ) ,  (int) ( NSYNC_SECOND ) ) ; 
                __context__.SourceCodeLine = 66;
                Functions.SetDate (  (int) ( NSYNC_MONTH ) ,  (int) ( NSYNC_DATE ) ,  (int) ( NSYNC_YEAR ) ) ; 
                __context__.SourceCodeLine = 68;
                G_NSEMAPHORE = (ushort) ( 0 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SYNC_TIME_B = new Crestron.Logos.SplusObjects.DigitalInput( SYNC_TIME_B__DigitalInput__, this );
    m_DigitalInputList.Add( SYNC_TIME_B__DigitalInput__, SYNC_TIME_B );
    
    LOCAL_DATE_TIME_QUERY_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LOCAL_DATE_TIME_QUERY_RX__DOLLAR____AnalogSerialInput__, 200, this );
    m_StringInputList.Add( LOCAL_DATE_TIME_QUERY_RX__DOLLAR____AnalogSerialInput__, LOCAL_DATE_TIME_QUERY_RX__DOLLAR__ );
    
    LOCAL_DATE_TIME_QUERY_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LOCAL_DATE_TIME_QUERY_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( LOCAL_DATE_TIME_QUERY_TX__DOLLAR____AnalogSerialOutput__, LOCAL_DATE_TIME_QUERY_TX__DOLLAR__ );
    
    INSTANCEID = new UShortParameter( INSTANCEID__Parameter__, this );
    m_ParameterList.Add( INSTANCEID__Parameter__, INSTANCEID );
    
    
    SYNC_TIME_B.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYNC_TIME_B_OnPush_0, false ) );
    LOCAL_DATE_TIME_QUERY_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LOCAL_DATE_TIME_QUERY_RX__DOLLAR___OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_FUSION_TIME_SYNC_V1_10 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SYNC_TIME_B__DigitalInput__ = 0;
const uint LOCAL_DATE_TIME_QUERY_RX__DOLLAR____AnalogSerialInput__ = 0;
const uint LOCAL_DATE_TIME_QUERY_TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint INSTANCEID__Parameter__ = 10;

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
