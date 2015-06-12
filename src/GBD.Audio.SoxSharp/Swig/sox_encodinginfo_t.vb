Imports System.Runtime.InteropServices

' ----------------------------------------------------------------------------
' * This file was automatically generated by SWIG (http://www.swig.org).
' * Version 2.0.10
' *
' * Do not make changes to this file unless you know what you are doing--modify
' * the SWIG interface file instead.
' * ----------------------------------------------------------------------------- 

Namespace swig


    Public Class sox_encodinginfo_t
        Implements IDisposable
        Private swigCPtr As HandleRef
        Protected swigCMemOwn As Boolean

        Friend Sub New(ByVal cPtr As IntPtr, ByVal cMemoryOwn As Boolean)
            swigCMemOwn = cMemoryOwn
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Friend Shared Function getCPtr(ByVal obj As sox_encodinginfo_t) As HandleRef
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
                        libsoxPINVOKE.delete_sox_encodinginfo_t(swigCPtr)
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


        Public Property encoding() As sox_encoding_t
            Set(ByVal value As sox_encoding_t)
                libsoxPINVOKE.sox_encodinginfo_t_encoding_set(swigCPtr, CInt(value))
            End Set
            Get
                Dim ret As sox_encoding_t = CType(libsoxPINVOKE.sox_encodinginfo_t_encoding_get(swigCPtr), sox_encoding_t)
                Return ret
            End Get
        End Property

        Public Property bits_per_sample() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_encodinginfo_t_bits_per_sample_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_encodinginfo_t_bits_per_sample_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property compression() As Double
            Set(ByVal value As Double)
                libsoxPINVOKE.sox_encodinginfo_t_compression_set(swigCPtr, value)
            End Set
            Get
                Dim ret As Double = libsoxPINVOKE.sox_encodinginfo_t_compression_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property reverse_bytes() As sox_option_t
            Set(ByVal value As sox_option_t)
                libsoxPINVOKE.sox_encodinginfo_t_reverse_bytes_set(swigCPtr, CInt(value))
            End Set
            Get
                Dim ret As sox_option_t = CType(libsoxPINVOKE.sox_encodinginfo_t_reverse_bytes_get(swigCPtr), sox_option_t)
                Return ret
            End Get
        End Property

        Public Property reverse_nibbles() As sox_option_t
            Set(ByVal value As sox_option_t)
                libsoxPINVOKE.sox_encodinginfo_t_reverse_nibbles_set(swigCPtr, CInt(value))
            End Set
            Get
                Dim ret As sox_option_t = CType(libsoxPINVOKE.sox_encodinginfo_t_reverse_nibbles_get(swigCPtr), sox_option_t)
                Return ret
            End Get
        End Property

        Public Property reverse_bits() As sox_option_t
            Set(ByVal value As sox_option_t)
                libsoxPINVOKE.sox_encodinginfo_t_reverse_bits_set(swigCPtr, CInt(value))
            End Set
            Get
                Dim ret As sox_option_t = CType(libsoxPINVOKE.sox_encodinginfo_t_reverse_bits_get(swigCPtr), sox_option_t)
                Return ret
            End Get
        End Property

        Public Property opposite_endian() As sox_bool
            Set(ByVal value As sox_bool)
                libsoxPINVOKE.sox_encodinginfo_t_opposite_endian_set(swigCPtr, CInt(value))
            End Set
            Get
                Dim ret As sox_bool = CType(libsoxPINVOKE.sox_encodinginfo_t_opposite_endian_get(swigCPtr), sox_bool)
                Return ret
            End Get
        End Property

        Public Sub New()
            Me.New(libsoxPINVOKE.new_sox_encodinginfo_t(), True)
        End Sub

    End Class

End Namespace
