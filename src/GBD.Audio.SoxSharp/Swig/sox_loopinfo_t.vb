Imports System.Runtime.InteropServices

' ----------------------------------------------------------------------------
' * This file was automatically generated by SWIG (http://www.swig.org).
' * Version 2.0.10
' *
' * Do not make changes to this file unless you know what you are doing--modify
' * the SWIG interface file instead.
' * ----------------------------------------------------------------------------- 

Namespace swig


    Public Class sox_loopinfo_t
        Implements IDisposable
        Private swigCPtr As HandleRef
        Protected swigCMemOwn As Boolean

        Friend Sub New(ByVal cPtr As IntPtr, ByVal cMemoryOwn As Boolean)
            swigCMemOwn = cMemoryOwn
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Friend Shared Function getCPtr(ByVal obj As sox_loopinfo_t) As HandleRef
            Return If(obj Is Nothing, New HandleRef(Nothing, IntPtr.Zero), obj.swigCPtr)
        End Function

        Protected Overrides Sub Finalize()
            Dispose()
        End Sub

        Public Overridable Sub Dispose() Implements IDisposable.Dispose
            SyncLock Me
                If swigCPtr.Handle <> IntPtr.Zero Then
                    If swigCMemOwn Then
                        swigCMemOwn = False
                        libsoxPINVOKE.delete_sox_loopinfo_t(swigCPtr)
                    End If
                    swigCPtr = New HandleRef(Nothing, IntPtr.Zero)
                End If
                GC.SuppressFinalize(Me)
            End SyncLock
        End Sub

        Public Sub New(ByVal cPtr As IntPtr)
            swigCMemOwn = False
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Public Function GetswigCPtr() As IntPtr
            Return swigCPtr.Handle
        End Function


        Public Property start() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_loopinfo_t_start_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_loopinfo_t_start_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property length() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_loopinfo_t_length_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_loopinfo_t_length_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property count() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_loopinfo_t_count_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_loopinfo_t_count_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property type() As Byte
            Set(ByVal value As Byte)
                libsoxPINVOKE.sox_loopinfo_t_type_set(swigCPtr, value)
            End Set
            Get
                Dim ret As Byte = libsoxPINVOKE.sox_loopinfo_t_type_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Sub New()
            Me.New(libsoxPINVOKE.new_sox_loopinfo_t(), True)
        End Sub

    End Class

End Namespace
