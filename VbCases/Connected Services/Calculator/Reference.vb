﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace Calculator
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="Calculator.ICalculator")>  _
    Public Interface ICalculator
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ICalculator/Add", ReplyAction:="http://tempuri.org/ICalculator/AddResponse")>  _
        Function Add(ByVal x As Double, ByVal y As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ICalculator/Add", ReplyAction:="http://tempuri.org/ICalculator/AddResponse")>  _
        Function AddAsync(ByVal x As Double, ByVal y As Double) As System.Threading.Tasks.Task(Of Double)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ICalculatorChannel
        Inherits Calculator.ICalculator, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class CalculatorClient
        Inherits System.ServiceModel.ClientBase(Of Calculator.ICalculator)
        Implements Calculator.ICalculator
        
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
        
        Public Function Add(ByVal x As Double, ByVal y As Double) As Double Implements Calculator.ICalculator.Add
            Return MyBase.Channel.Add(x, y)
        End Function
        
        Public Function AddAsync(ByVal x As Double, ByVal y As Double) As System.Threading.Tasks.Task(Of Double) Implements Calculator.ICalculator.AddAsync
            Return MyBase.Channel.AddAsync(x, y)
        End Function
    End Class
End Namespace
