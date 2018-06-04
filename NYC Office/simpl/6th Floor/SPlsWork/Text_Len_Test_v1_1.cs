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

namespace UserModule_TEXT_LEN_TEST_V1_1
{
    public class UserModuleClass_TEXT_LEN_TEST_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.StringInput TEXT__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput TEXT_HAS_LENGTH;
        object TEXT__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 67;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEXT__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 68;
                    TEXT_HAS_LENGTH  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 70;
                    TEXT_HAS_LENGTH  .Value = (ushort) ( 0 ) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        TEXT_HAS_LENGTH = new Crestron.Logos.SplusObjects.DigitalOutput( TEXT_HAS_LENGTH__DigitalOutput__, this );
        m_DigitalOutputList.Add( TEXT_HAS_LENGTH__DigitalOutput__, TEXT_HAS_LENGTH );
        
        TEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TEXT__DOLLAR____AnalogSerialInput__, 255, this );
        m_StringInputList.Add( TEXT__DOLLAR____AnalogSerialInput__, TEXT__DOLLAR__ );
        
        
        TEXT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TEXT__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_TEXT_LEN_TEST_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint TEXT__DOLLAR____AnalogSerialInput__ = 0;
    const uint TEXT_HAS_LENGTH__DigitalOutput__ = 0;
    
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
