﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3074
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


'
'This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 3.0.40624.0
'
Namespace DeepZoomServiceReference
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://code.fx/", ConfigurationName:="DeepZoomServiceReference.IGenerateDeepZoomService")>  _
    Public Interface IGenerateDeepZoomService
        
        <System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://code.fx/IGenerateDeepZoomService/PrepareDeepZoom", ReplyAction:="http://code.fx/IGenerateDeepZoomService/PrepareDeepZoomResponse")>  _
        Function BeginPrepareDeepZoom(ByVal forceGenerateDeepZoom As Boolean, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Function EndPrepareDeepZoom(ByVal result As System.IAsyncResult) As Boolean
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface IGenerateDeepZoomServiceChannel
        Inherits DeepZoomServiceReference.IGenerateDeepZoomService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class PrepareDeepZoomCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Public Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        Public ReadOnly Property Result() As Boolean
            Get
                MyBase.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class GenerateDeepZoomServiceClient
        Inherits System.ServiceModel.ClientBase(Of DeepZoomServiceReference.IGenerateDeepZoomService)
        Implements DeepZoomServiceReference.IGenerateDeepZoomService
        
        Private onBeginPrepareDeepZoomDelegate As BeginOperationDelegate
        
        Private onEndPrepareDeepZoomDelegate As EndOperationDelegate
        
        Private onPrepareDeepZoomCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginOpenDelegate As BeginOperationDelegate
        
        Private onEndOpenDelegate As EndOperationDelegate
        
        Private onOpenCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginCloseDelegate As BeginOperationDelegate
        
        Private onEndCloseDelegate As EndOperationDelegate
        
        Private onCloseCompletedDelegate As System.Threading.SendOrPostCallback
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
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
        
        Public Event PrepareDeepZoomCompleted As System.EventHandler(Of PrepareDeepZoomCompletedEventArgs)
        
        Public Event OpenCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        Public Event CloseCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function DeepZoomServiceReference_IGenerateDeepZoomService_BeginPrepareDeepZoom(ByVal forceGenerateDeepZoom As Boolean, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements DeepZoomServiceReference.IGenerateDeepZoomService.BeginPrepareDeepZoom
            Return MyBase.Channel.BeginPrepareDeepZoom(forceGenerateDeepZoom, callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function DeepZoomServiceReference_IGenerateDeepZoomService_EndPrepareDeepZoom(ByVal result As System.IAsyncResult) As Boolean Implements DeepZoomServiceReference.IGenerateDeepZoomService.EndPrepareDeepZoom
            Return MyBase.Channel.EndPrepareDeepZoom(result)
        End Function
        
        Private Function OnBeginPrepareDeepZoom(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Dim forceGenerateDeepZoom As Boolean = CType(inValues(0),Boolean)
            Return CType(Me,DeepZoomServiceReference.IGenerateDeepZoomService).BeginPrepareDeepZoom(forceGenerateDeepZoom, callback, asyncState)
        End Function
        
        Private Function OnEndPrepareDeepZoom(ByVal result As System.IAsyncResult) As Object()
            Dim retVal As Boolean = CType(Me,DeepZoomServiceReference.IGenerateDeepZoomService).EndPrepareDeepZoom(result)
            Return New Object() {retVal}
        End Function
        
        Private Sub OnPrepareDeepZoomCompleted(ByVal state As Object)
            If (Not (Me.PrepareDeepZoomCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent PrepareDeepZoomCompleted(Me, New PrepareDeepZoomCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub PrepareDeepZoomAsync(ByVal forceGenerateDeepZoom As Boolean)
            Me.PrepareDeepZoomAsync(forceGenerateDeepZoom, Nothing)
        End Sub
        
        Public Overloads Sub PrepareDeepZoomAsync(ByVal forceGenerateDeepZoom As Boolean, ByVal userState As Object)
            If (Me.onBeginPrepareDeepZoomDelegate Is Nothing) Then
                Me.onBeginPrepareDeepZoomDelegate = AddressOf Me.OnBeginPrepareDeepZoom
            End If
            If (Me.onEndPrepareDeepZoomDelegate Is Nothing) Then
                Me.onEndPrepareDeepZoomDelegate = AddressOf Me.OnEndPrepareDeepZoom
            End If
            If (Me.onPrepareDeepZoomCompletedDelegate Is Nothing) Then
                Me.onPrepareDeepZoomCompletedDelegate = AddressOf Me.OnPrepareDeepZoomCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginPrepareDeepZoomDelegate, New Object() {forceGenerateDeepZoom}, Me.onEndPrepareDeepZoomDelegate, Me.onPrepareDeepZoomCompletedDelegate, userState)
        End Sub
        
        Private Function OnBeginOpen(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
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
        
        Protected Overrides Function CreateChannel() As DeepZoomServiceReference.IGenerateDeepZoomService
            Return New GenerateDeepZoomServiceClientChannel(Me)
        End Function
        
        Private Class GenerateDeepZoomServiceClientChannel
            Inherits ChannelBase(Of DeepZoomServiceReference.IGenerateDeepZoomService)
            Implements DeepZoomServiceReference.IGenerateDeepZoomService
            
            Public Sub New(ByVal client As System.ServiceModel.ClientBase(Of DeepZoomServiceReference.IGenerateDeepZoomService))
                MyBase.New(client)
            End Sub
            
            Public Function BeginPrepareDeepZoom(ByVal forceGenerateDeepZoom As Boolean, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements DeepZoomServiceReference.IGenerateDeepZoomService.BeginPrepareDeepZoom
                Dim _args((1) - 1) As Object
                _args(0) = forceGenerateDeepZoom
                Dim _result As System.IAsyncResult = MyBase.BeginInvoke("PrepareDeepZoom", _args, callback, asyncState)
                Return _result
            End Function
            
            Public Function EndPrepareDeepZoom(ByVal result As System.IAsyncResult) As Boolean Implements DeepZoomServiceReference.IGenerateDeepZoomService.EndPrepareDeepZoom
                Dim _args((0) - 1) As Object
                Dim _result As Boolean = CType(MyBase.EndInvoke("PrepareDeepZoom", _args, result),Boolean)
                Return _result
            End Function
        End Class
    End Class
End Namespace
