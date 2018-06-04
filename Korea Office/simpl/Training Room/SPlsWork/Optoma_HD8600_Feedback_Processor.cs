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

namespace UserModule_OPTOMA_HD8600_FEEDBACK_PROCESSOR
{
    public class UserModuleClass_OPTOMA_HD8600_FEEDBACK_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.StringInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput LAMP_HOURS;
        Crestron.Logos.SplusObjects.StringOutput LAMP_HOURS_TEXT;
        CrestronString TEMP__DOLLAR__;
        object FROM_DEVICE__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 73;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FROM_DEVICE__DOLLAR__ ) > 8 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 77;
                    TEMP__DOLLAR__  .UpdateValue ( Functions.Mid ( FROM_DEVICE__DOLLAR__ ,  (int) ( 4 ) ,  (int) ( 4 ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 81;
                LAMP_HOURS  .Value = (ushort) ( Functions.Atoi( TEMP__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 82;
                LAMP_HOURS_TEXT  .UpdateValue ( TEMP__DOLLAR__  ) ; 
                
                
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
            
            __context__.SourceCodeLine = 99;
            WaitForInitializationComplete ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        SocketInfo __socketinfo__ = new SocketInfo( 1, this );
        InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
        _SplusNVRAM = new SplusNVRAM( this );
        TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        
        LAMP_HOURS = new Crestron.Logos.SplusObjects.AnalogOutput( LAMP_HOURS__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( LAMP_HOURS__AnalogSerialOutput__, LAMP_HOURS );
        
        FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 20, this );
        m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
        
        LAMP_HOURS_TEXT = new Crestron.Logos.SplusObjects.StringOutput( LAMP_HOURS_TEXT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( LAMP_HOURS_TEXT__AnalogSerialOutput__, LAMP_HOURS_TEXT );
        
        
        FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_OPTOMA_HD8600_FEEDBACK_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 0;
    const uint LAMP_HOURS__AnalogSerialOutput__ = 0;
    const uint LAMP_HOURS_TEXT__AnalogSerialOutput__ = 1;
    
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
