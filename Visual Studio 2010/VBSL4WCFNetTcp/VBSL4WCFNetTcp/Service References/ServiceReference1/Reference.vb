﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


'
'This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50401.0
'
Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.IWeatherService", CallbackContract:=GetType(ServiceReference1.IWeatherServiceCallback))>  _
    Public Interface IWeatherService
        
        <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, AsyncPattern:=true, Action:="http://tempuri.org/IWeatherService/Subscribe")>  _
        Function BeginSubscribe(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Sub EndSubscribe(ByVal result As System.IAsyncResult)
        
        <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, AsyncPattern:=true, Action:="http://tempuri.org/IWeatherService/UnSubscribe")>  _
        Function BeginUnSubscribe(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Sub EndUnSubscribe(ByVal result As System.IAsyncResult)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IWeatherServiceCallback
        
        <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://tempuri.org/IWeatherService/WeatherReport")>  _
        Sub WeatherReport(ByVal report As String)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IWeatherServiceChannel
        Inherits ServiceReference1.IWeatherService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class WeatherServiceClient
        Inherits System.ServiceModel.DuplexClientBase(Of ServiceReference1.IWeatherService)
        Implements ServiceReference1.IWeatherService
        
        Private onBeginSubscribeDelegate As BeginOperationDelegate
        
        Private onEndSubscribeDelegate As EndOperationDelegate
        
        Private onSubscribeCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginUnSubscribeDelegate As BeginOperationDelegate
        
        Private onEndUnSubscribeDelegate As EndOperationDelegate
        
        Private onUnSubscribeCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private useGeneratedCallback As Boolean
        
        Private onBeginOpenDelegate As BeginOperationDelegate
        
        Private onEndOpenDelegate As EndOperationDelegate
        
        Private onOpenCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginCloseDelegate As BeginOperationDelegate
        
        Private onEndCloseDelegate As EndOperationDelegate
        
        Private onCloseCompletedDelegate As System.Threading.SendOrPostCallback
        
        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext)
            MyBase.New(callbackInstance)
        End Sub
        
        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String)
            MyBase.New(callbackInstance, endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(callbackInstance, binding, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            Me.New(New WeatherServiceClientCallback(), endpointConfigurationName)
        End Sub
        
        Private Sub New(ByVal callbackImpl As WeatherServiceClientCallback, ByVal endpointConfigurationName As String)
            Me.New(New System.ServiceModel.InstanceContext(callbackImpl), endpointConfigurationName)
            useGeneratedCallback = true
            callbackImpl.Initialize(Me)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            Me.New(New WeatherServiceClientCallback(), binding, remoteAddress)
        End Sub
        
        Private Sub New(ByVal callbackImpl As WeatherServiceClientCallback, ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            Me.New(New System.ServiceModel.InstanceContext(callbackImpl), binding, remoteAddress)
            useGeneratedCallback = true
            callbackImpl.Initialize(Me)
        End Sub
        
        Public Sub New()
            Me.New(New WeatherServiceClientCallback())
        End Sub
        
        Private Sub New(ByVal callbackImpl As WeatherServiceClientCallback)
            Me.New(New System.ServiceModel.InstanceContext(callbackImpl))
            useGeneratedCallback = true
            callbackImpl.Initialize(Me)
        End Sub
        
        Public Property CookieContainer() As System.Net.CookieContainer
            Get
                Dim httpCookieContainerManager As System.ServiceModel.Channels.IHttpCookieContainerManager = Me.InnerChannel.GetProperty(Of System.ServiceModel.Channels.IHttpCookieContainerManager)
                If (Not (httpCookieContainerManager) Is Nothing) Then
                    Return httpCookieContainerManager.CookieContainer
                Else
                    Return Nothing
                End If
            End Get
            Set
                Dim httpCookieContainerManager As System.ServiceModel.Channels.IHttpCookieContainerManager = Me.InnerChannel.GetProperty(Of System.ServiceModel.Channels.IHttpCookieContainerManager)
                If (Not (httpCookieContainerManager) Is Nothing) Then
                    httpCookieContainerManager.CookieContainer = value
                Else
                    Throw New System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC"& _ 
                            "ookieContainerBindingElement.")
                End If
            End Set
        End Property
        
        Public Event SubscribeCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        Public Event UnSubscribeCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        Public Event WeatherReportReceived As System.EventHandler(Of WeatherReportReceivedEventArgs)
        
        Public Event OpenCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        Public Event CloseCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_IWeatherService_BeginSubscribe(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements ServiceReference1.IWeatherService.BeginSubscribe
            Return MyBase.Channel.BeginSubscribe(callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Sub ServiceReference1_IWeatherService_EndSubscribe(ByVal result As System.IAsyncResult) Implements ServiceReference1.IWeatherService.EndSubscribe
            MyBase.Channel.EndSubscribe(result)
        End Sub
        
        Private Function OnBeginSubscribe(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Me.VerifyCallbackEvents
            Return CType(Me,ServiceReference1.IWeatherService).BeginSubscribe(callback, asyncState)
        End Function
        
        Private Function OnEndSubscribe(ByVal result As System.IAsyncResult) As Object()
            CType(Me,ServiceReference1.IWeatherService).EndSubscribe(result)
            Return Nothing
        End Function
        
        Private Sub OnSubscribeCompleted(ByVal state As Object)
            If (Not (Me.SubscribeCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent SubscribeCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub SubscribeAsync()
            Me.SubscribeAsync(Nothing)
        End Sub
        
        Public Overloads Sub SubscribeAsync(ByVal userState As Object)
            If (Me.onBeginSubscribeDelegate Is Nothing) Then
                Me.onBeginSubscribeDelegate = AddressOf Me.OnBeginSubscribe
            End If
            If (Me.onEndSubscribeDelegate Is Nothing) Then
                Me.onEndSubscribeDelegate = AddressOf Me.OnEndSubscribe
            End If
            If (Me.onSubscribeCompletedDelegate Is Nothing) Then
                Me.onSubscribeCompletedDelegate = AddressOf Me.OnSubscribeCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginSubscribeDelegate, Nothing, Me.onEndSubscribeDelegate, Me.onSubscribeCompletedDelegate, userState)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_IWeatherService_BeginUnSubscribe(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements ServiceReference1.IWeatherService.BeginUnSubscribe
            Return MyBase.Channel.BeginUnSubscribe(callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Sub ServiceReference1_IWeatherService_EndUnSubscribe(ByVal result As System.IAsyncResult) Implements ServiceReference1.IWeatherService.EndUnSubscribe
            MyBase.Channel.EndUnSubscribe(result)
        End Sub
        
        Private Function OnBeginUnSubscribe(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Me.VerifyCallbackEvents
            Return CType(Me,ServiceReference1.IWeatherService).BeginUnSubscribe(callback, asyncState)
        End Function
        
        Private Function OnEndUnSubscribe(ByVal result As System.IAsyncResult) As Object()
            CType(Me,ServiceReference1.IWeatherService).EndUnSubscribe(result)
            Return Nothing
        End Function
        
        Private Sub OnUnSubscribeCompleted(ByVal state As Object)
            If (Not (Me.UnSubscribeCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent UnSubscribeCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub UnSubscribeAsync()
            Me.UnSubscribeAsync(Nothing)
        End Sub
        
        Public Overloads Sub UnSubscribeAsync(ByVal userState As Object)
            If (Me.onBeginUnSubscribeDelegate Is Nothing) Then
                Me.onBeginUnSubscribeDelegate = AddressOf Me.OnBeginUnSubscribe
            End If
            If (Me.onEndUnSubscribeDelegate Is Nothing) Then
                Me.onEndUnSubscribeDelegate = AddressOf Me.OnEndUnSubscribe
            End If
            If (Me.onUnSubscribeCompletedDelegate Is Nothing) Then
                Me.onUnSubscribeCompletedDelegate = AddressOf Me.OnUnSubscribeCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginUnSubscribeDelegate, Nothing, Me.onEndUnSubscribeDelegate, Me.onUnSubscribeCompletedDelegate, userState)
        End Sub
        
        Private Sub OnWeatherReportReceived(ByVal state As Object)
            If (Not (Me.WeatherReportReceivedEvent) Is Nothing) Then
                Dim results() As Object = CType(state,Object())
                RaiseEvent WeatherReportReceived(Me, New WeatherReportReceivedEventArgs(results, Nothing, false, Nothing))
            End If
        End Sub
        
        Private Sub VerifyCallbackEvents()
            If ((Me.useGeneratedCallback <> true)  _
                        AndAlso (Not (Me.WeatherReportReceivedEvent) Is Nothing)) Then
                Throw New System.InvalidOperationException("Callback events cannot be used when the callback InstanceContext is specified. Pl"& _ 
                        "ease choose between specifying the callback InstanceContext or subscribing to th"& _ 
                        "e callback events.")
            End If
        End Sub
        
        Private Function OnBeginOpen(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Me.VerifyCallbackEvents
            Return CType(Me,System.ServiceModel.ICommunicationObject).BeginOpen(callback, asyncState)
        End Function
        
        Private Function OnEndOpen(ByVal result As System.IAsyncResult) As Object()
            CType(Me,System.ServiceModel.ICommunicationObject).EndOpen(result)
            Return Nothing
        End Function
        
        Private Sub OnOpenCompleted(ByVal state As Object)
            If (Not (Me.OpenCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent OpenCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.[Error], e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub OpenAsync()
            Me.OpenAsync(Nothing)
        End Sub
        
        Public Overloads Sub OpenAsync(ByVal userState As Object)
            If (Me.onBeginOpenDelegate Is Nothing) Then
                Me.onBeginOpenDelegate = AddressOf Me.OnBeginOpen
            End If
            If (Me.onEndOpenDelegate Is Nothing) Then
                Me.onEndOpenDelegate = AddressOf Me.OnEndOpen
            End If
            If (Me.onOpenCompletedDelegate Is Nothing) Then
                Me.onOpenCompletedDelegate = AddressOf Me.OnOpenCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginOpenDelegate, Nothing, Me.onEndOpenDelegate, Me.onOpenCompletedDelegate, userState)
        End Sub
        
        Private Function OnBeginClose(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,System.ServiceModel.ICommunicationObject).BeginClose(callback, asyncState)
        End Function
        
        Private Function OnEndClose(ByVal result As System.IAsyncResult) As Object()
            CType(Me,System.ServiceModel.ICommunicationObject).EndClose(result)
            Return Nothing
        End Function
        
        Private Sub OnCloseCompleted(ByVal state As Object)
            If (Not (Me.CloseCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent CloseCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.[Error], e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub CloseAsync()
            Me.CloseAsync(Nothing)
        End Sub
        
        Public Overloads Sub CloseAsync(ByVal userState As Object)
            If (Me.onBeginCloseDelegate Is Nothing) Then
                Me.onBeginCloseDelegate = AddressOf Me.OnBeginClose
            End If
            If (Me.onEndCloseDelegate Is Nothing) Then
                Me.onEndCloseDelegate = AddressOf Me.OnEndClose
            End If
            If (Me.onCloseCompletedDelegate Is Nothing) Then
                Me.onCloseCompletedDelegate = AddressOf Me.OnCloseCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginCloseDelegate, Nothing, Me.onEndCloseDelegate, Me.onCloseCompletedDelegate, userState)
        End Sub
        
        Protected Overrides Function CreateChannel() As ServiceReference1.IWeatherService
            Return New WeatherServiceClientChannel(Me)
        End Function
        
        Private Class WeatherServiceClientCallback
            Inherits Object
            Implements IWeatherServiceCallback
            
            Private proxy As WeatherServiceClient
            
            Public Sub Initialize(ByVal proxy As WeatherServiceClient)
                Me.proxy = proxy
            End Sub
            
            Public Sub WeatherReport(ByVal report As String) Implements IWeatherServiceCallback.WeatherReport
                Me.proxy.OnWeatherReportReceived(New Object() {report})
            End Sub
        End Class
        
        Private Class WeatherServiceClientChannel
            Inherits ChannelBase(Of ServiceReference1.IWeatherService)
            Implements ServiceReference1.IWeatherService
            
            Public Sub New(ByVal client As System.ServiceModel.DuplexClientBase(Of ServiceReference1.IWeatherService))
                MyBase.New(client)
            End Sub
            
            Public Function BeginSubscribe(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements ServiceReference1.IWeatherService.BeginSubscribe
                Dim _args((0) - 1) As Object
                Dim _result As System.IAsyncResult = MyBase.BeginInvoke("Subscribe", _args, callback, asyncState)
                Return _result
            End Function
            
            Public Sub EndSubscribe(ByVal result As System.IAsyncResult) Implements ServiceReference1.IWeatherService.EndSubscribe
                Dim _args((0) - 1) As Object
                MyBase.EndInvoke("Subscribe", _args, result)
            End Sub
            
            Public Function BeginUnSubscribe(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements ServiceReference1.IWeatherService.BeginUnSubscribe
                Dim _args((0) - 1) As Object
                Dim _result As System.IAsyncResult = MyBase.BeginInvoke("UnSubscribe", _args, callback, asyncState)
                Return _result
            End Function
            
            Public Sub EndUnSubscribe(ByVal result As System.IAsyncResult) Implements ServiceReference1.IWeatherService.EndUnSubscribe
                Dim _args((0) - 1) As Object
                MyBase.EndInvoke("UnSubscribe", _args, result)
            End Sub
        End Class
    End Class
    
    Public Class WeatherReportReceivedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Public Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        Public ReadOnly Property report() As String
            Get
                MyBase.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
