Imports System.Runtime.InteropServices

' ----------------------------------------------------------------------------
' * This file was automatically generated by SWIG (http://www.swig.org).
' * Version 2.0.10
' *
' * Do not make changes to this file unless you know what you are doing--modify
' * the SWIG interface file instead.
' * ----------------------------------------------------------------------------- 

Namespace swig


    Public Class sox_format_t
        Implements IDisposable
        Private swigCPtr As HandleRef
        Protected swigCMemOwn As Boolean

        Friend Sub New(ByVal cPtr As IntPtr, ByVal cMemoryOwn As Boolean)
            swigCMemOwn = cMemoryOwn
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Friend Shared Function getCPtr(ByVal obj As sox_format_t) As HandleRef
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
                        libsoxPINVOKE.delete_sox_format_t(swigCPtr)
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


        Public Property filename() As String
            Set(ByVal value As String)
                libsoxPINVOKE.sox_format_t_filename_set(swigCPtr, value)
            End Set
            Get
                Dim ret As String = libsoxPINVOKE.sox_format_t_filename_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property signal() As sox_signalinfo_t
            Set(ByVal value As sox_signalinfo_t)
                libsoxPINVOKE.sox_format_t_signal_set(swigCPtr, sox_signalinfo_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_t_signal_get(swigCPtr)
                Dim ret As sox_signalinfo_t = If(cPtr = IntPtr.Zero, Nothing, New sox_signalinfo_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property encoding() As sox_encodinginfo_t
            Set(ByVal value As sox_encodinginfo_t)
                libsoxPINVOKE.sox_format_t_encoding_set(swigCPtr, sox_encodinginfo_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_t_encoding_get(swigCPtr)
                Dim ret As sox_encodinginfo_t = If(cPtr = IntPtr.Zero, Nothing, New sox_encodinginfo_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property filetype() As String
            Set(ByVal value As String)
                libsoxPINVOKE.sox_format_t_filetype_set(swigCPtr, value)
            End Set
            Get
                Dim ret As String = libsoxPINVOKE.sox_format_t_filetype_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property oob() As sox_oob_t
            Set(ByVal value As sox_oob_t)
                libsoxPINVOKE.sox_format_t_oob_set(swigCPtr, sox_oob_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_t_oob_get(swigCPtr)
                Dim ret As sox_oob_t = If(cPtr = IntPtr.Zero, Nothing, New sox_oob_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property seekable() As sox_bool
            Set(ByVal value As sox_bool)
                libsoxPINVOKE.sox_format_t_seekable_set(swigCPtr, CInt(value))
            End Set
            Get
                Dim ret As sox_bool = CType(libsoxPINVOKE.sox_format_t_seekable_get(swigCPtr), sox_bool)
                Return ret
            End Get
        End Property

        Public Property mode() As Char
            Set(ByVal value As Char)
                libsoxPINVOKE.sox_format_t_mode_set(swigCPtr, value)
            End Set
            Get
                Dim ret As Char = libsoxPINVOKE.sox_format_t_mode_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property olength() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_format_t_olength_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_format_t_olength_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property clips() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_format_t_clips_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_format_t_clips_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property sox_errno() As Integer
            Set(ByVal value As Integer)
                libsoxPINVOKE.sox_format_t_sox_errno_set(swigCPtr, value)
            End Set
            Get
                Dim ret As Integer = libsoxPINVOKE.sox_format_t_sox_errno_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property sox_errstr() As String
            Set(ByVal value As String)
                libsoxPINVOKE.sox_format_t_sox_errstr_set(swigCPtr, value)
            End Set
            Get
                Dim ret As String = libsoxPINVOKE.sox_format_t_sox_errstr_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property fp() As SWIGTYPE_p_void
            Set(ByVal value As SWIGTYPE_p_void)
                libsoxPINVOKE.sox_format_t_fp_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_t_fp_get(swigCPtr)
                Dim ret As SWIGTYPE_p_void = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_void(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property io_type() As lsx_io_type
            Set(ByVal value As lsx_io_type)
                libsoxPINVOKE.sox_format_t_io_type_set(swigCPtr, CInt(value))
            End Set
            Get
                Dim ret As lsx_io_type = CType(libsoxPINVOKE.sox_format_t_io_type_get(swigCPtr), lsx_io_type)
                Return ret
            End Get
        End Property

        Public Property tell_off() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_format_t_tell_off_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_format_t_tell_off_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property data_start() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_format_t_data_start_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_format_t_data_start_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property handler() As SWIGTYPE_p_sox_format_handler_t
            Set(ByVal value As SWIGTYPE_p_sox_format_handler_t)
                libsoxPINVOKE.sox_format_t_handler_set(swigCPtr, SWIGTYPE_p_sox_format_handler_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_t_handler_get(swigCPtr)
                Dim ret As SWIGTYPE_p_sox_format_handler_t = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_sox_format_handler_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property priv() As SWIGTYPE_p_void
            Set(ByVal value As SWIGTYPE_p_void)
                libsoxPINVOKE.sox_format_t_priv_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_t_priv_get(swigCPtr)
                Dim ret As SWIGTYPE_p_void = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_void(cPtr, False))
                Return ret
            End Get
        End Property

        Public Sub New()
            Me.New(libsoxPINVOKE.new_sox_format_t(), True)
        End Sub

    End Class

End Namespace
