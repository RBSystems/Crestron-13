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

namespace CrestronModule_CORE_3_XPANEL_WEB_CONFIGURATION_MODULE_V1_1
{
    public class CrestronModuleClass_CORE_3_XPANEL_WEB_CONFIGURATION_MODULE_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        SplusTcpServer SECURITYSERVER;
        
        object SECURITYSERVER_OnSocketReceive_0 ( Object __Info__ )
        
            { 
            SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
                short FILEHANDLE = 0;
                short COUNT = 0;
                
                CrestronString BUFFER;
                BUFFER  = new CrestronString( InheritedStringEncoding, 8192, this );
                
                
                __context__.SourceCodeLine = 28;
                Functions.ClearBuffer ( SECURITYSERVER .  SocketRxBuf ) ; 
                __context__.SourceCodeLine = 30;
                BUFFER  .UpdateValue ( "<?xml version=\u00221.0\u0022?>\u000A\u000D<!DOCTYPE cross-domain-policy SYSTEM \u0022/xml/dtds/cross-domain-policy.dtd\u0022>\u000A\u000D<!-- Policy file for xmlsocket://socks.example.com -->\u000A\u000D<cross-domain-policy>\u000A\u000D<!-- This is a master-policy file -->\u000A\u000D<site-control permitted-cross-domain-policies=\u0022master-only\u0022/>\u000A\u000D<!-- Instead of setting to-ports=\u0022*\u0022,administrators can use ranges and commas -->\u000A\u000D<allow-access-from domain=\u0022*\u0022 to-ports=\u0022*\u0022 />\u000A\u000D</cross-domain-policy>\u0000"  ) ; 
                __context__.SourceCodeLine = 31;
                Functions.SocketSend ( SECURITYSERVER , BUFFER ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SocketInfo__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        short STATUS = 0;
        
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 45;
            STATUS = (short) ( Functions.SocketServerStartListen( SECURITYSERVER , "0.0.0.0" , (ushort)( 843 ) ) ) ; 
            __context__.SourceCodeLine = 47;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUS < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 48;
                GenerateUserError ( "Error listening to {0} on port {1:d} (status: {2:d})", "0.0.0.0" , (ushort)843, (short)STATUS) ; 
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        SECURITYSERVER  = new SplusTcpServer ( 1024, this );
        
        
        SECURITYSERVER.OnSocketReceive.Add( new SocketHandlerWrapper( SECURITYSERVER_OnSocketReceive_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public CrestronModuleClass_CORE_3_XPANEL_WEB_CONFIGURATION_MODULE_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    
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
