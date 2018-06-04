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

namespace UserModule_TOGGLE_NV
{
    public class UserModuleClass_TOGGLE_NV : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput CLOCK;
        Crestron.Logos.SplusObjects.DigitalOutput YES_FB;
        Crestron.Logos.SplusObjects.DigitalOutput NO_FB;
        object CLOCK_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 115;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.LAST == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 117;
                    NO_FB  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 118;
                    YES_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 119;
                    _SplusNVRAM.LAST = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 122;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.LAST == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 125;
                        YES_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 126;
                        NO_FB  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 127;
                        _SplusNVRAM.LAST = (ushort) ( 0 ) ; 
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
            
            __context__.SourceCodeLine = 161;
            WaitForInitializationComplete ( ) ; 
            __context__.SourceCodeLine = 163;
            YES_FB  .Value = (ushort) ( _SplusNVRAM.LAST ) ; 
            __context__.SourceCodeLine = 164;
            NO_FB  .Value = (ushort) ( Functions.Not( _SplusNVRAM.LAST ) ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        CLOCK = new Crestron.Logos.SplusObjects.DigitalInput( CLOCK__DigitalInput__, this );
        m_DigitalInputList.Add( CLOCK__DigitalInput__, CLOCK );
        
        YES_FB = new Crestron.Logos.SplusObjects.DigitalOutput( YES_FB__DigitalOutput__, this );
        m_DigitalOutputList.Add( YES_FB__DigitalOutput__, YES_FB );
        
        NO_FB = new Crestron.Logos.SplusObjects.DigitalOutput( NO_FB__DigitalOutput__, this );
        m_DigitalOutputList.Add( NO_FB__DigitalOutput__, NO_FB );
        
        
        CLOCK.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLOCK_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_TOGGLE_NV ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint CLOCK__DigitalInput__ = 0;
    const uint YES_FB__DigitalOutput__ = 0;
    const uint NO_FB__DigitalOutput__ = 1;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        [SplusStructAttribute(0, false, true)]
            public ushort LAST = 0;
            
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
