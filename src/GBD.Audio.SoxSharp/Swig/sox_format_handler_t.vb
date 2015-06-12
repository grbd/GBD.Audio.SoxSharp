Imports System.Runtime.InteropServices

' ----------------------------------------------------------------------------
' * This file was automatically generated by SWIG (http://www.swig.org).
' * Version 2.0.10
' *
' * Do not make changes to this file unless you know what you are doing--modify
' * the SWIG interface file instead.
' * ----------------------------------------------------------------------------- 

Namespace swig


    Public Class sox_format_handler_t
        Implements IDisposable
        Private swigCPtr As HandleRef
        Protected swigCMemOwn As Boolean

        Friend Sub New(ByVal cPtr As IntPtr, ByVal cMemoryOwn As Boolean)
            swigCMemOwn = cMemoryOwn
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Friend Shared Function getCPtr(ByVal obj As sox_format_handler_t) As HandleRef
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
                        libsoxPINVOKE.delete_sox_format_handler_t(swigCPtr)
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


        Public Property sox_lib_version_code() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_format_handler_t_sox_lib_version_code_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_format_handler_t_sox_lib_version_code_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property description() As String
            Set(ByVal value As String)
                libsoxPINVOKE.sox_format_handler_t_description_set(swigCPtr, value)
            End Set
            Get
                Dim ret As String = libsoxPINVOKE.sox_format_handler_t_description_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property names() As SWIGTYPE_p_p_char
            Set(ByVal value As SWIGTYPE_p_p_char)
                libsoxPINVOKE.sox_format_handler_t_names_set(swigCPtr, SWIGTYPE_p_p_char.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_handler_t_names_get(swigCPtr)
                Dim ret As SWIGTYPE_p_p_char = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_p_char(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property flags() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_format_handler_t_flags_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_format_handler_t_flags_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Property startread() As SWIGTYPE_p_f_p_struct_sox_format_t__int
            Set(ByVal value As SWIGTYPE_p_f_p_struct_sox_format_t__int)
                libsoxPINVOKE.sox_format_handler_t_startread_set(swigCPtr, SWIGTYPE_p_f_p_struct_sox_format_t__int.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_handler_t_startread_get(swigCPtr)
                Dim ret As SWIGTYPE_p_f_p_struct_sox_format_t__int = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_f_p_struct_sox_format_t__int(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property read() As SWIGTYPE_p_f_p_struct_sox_format_t_p_int_size_t__size_t
            Set(ByVal value As SWIGTYPE_p_f_p_struct_sox_format_t_p_int_size_t__size_t)
                libsoxPINVOKE.sox_format_handler_t_read_set(swigCPtr, SWIGTYPE_p_f_p_struct_sox_format_t_p_int_size_t__size_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_handler_t_read_get(swigCPtr)
                Dim ret As SWIGTYPE_p_f_p_struct_sox_format_t_p_int_size_t__size_t = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_f_p_struct_sox_format_t_p_int_size_t__size_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property stopread() As SWIGTYPE_p_f_p_struct_sox_format_t__int
            Set(ByVal value As SWIGTYPE_p_f_p_struct_sox_format_t__int)
                libsoxPINVOKE.sox_format_handler_t_stopread_set(swigCPtr, SWIGTYPE_p_f_p_struct_sox_format_t__int.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_handler_t_stopread_get(swigCPtr)
                Dim ret As SWIGTYPE_p_f_p_struct_sox_format_t__int = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_f_p_struct_sox_format_t__int(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property startwrite() As SWIGTYPE_p_f_p_struct_sox_format_t__int
            Set(ByVal value As SWIGTYPE_p_f_p_struct_sox_format_t__int)
                libsoxPINVOKE.sox_format_handler_t_startwrite_set(swigCPtr, SWIGTYPE_p_f_p_struct_sox_format_t__int.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_handler_t_startwrite_get(swigCPtr)
                Dim ret As SWIGTYPE_p_f_p_struct_sox_format_t__int = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_f_p_struct_sox_format_t__int(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property write() As SWIGTYPE_p_f_p_struct_sox_format_t_p_q_const__int_size_t__size_t
            Set(ByVal value As SWIGTYPE_p_f_p_struct_sox_format_t_p_q_const__int_size_t__size_t)
                libsoxPINVOKE.sox_format_handler_t_write_set(swigCPtr, SWIGTYPE_p_f_p_struct_sox_format_t_p_q_const__int_size_t__size_t.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_handler_t_write_get(swigCPtr)
                Dim ret As SWIGTYPE_p_f_p_struct_sox_format_t_p_q_const__int_size_t__size_t = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_f_p_struct_sox_format_t_p_q_const__int_size_t__size_t(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property stopwrite() As SWIGTYPE_p_f_p_struct_sox_format_t__int
            Set(ByVal value As SWIGTYPE_p_f_p_struct_sox_format_t__int)
                libsoxPINVOKE.sox_format_handler_t_stopwrite_set(swigCPtr, SWIGTYPE_p_f_p_struct_sox_format_t__int.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_handler_t_stopwrite_get(swigCPtr)
                Dim ret As SWIGTYPE_p_f_p_struct_sox_format_t__int = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_f_p_struct_sox_format_t__int(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property seek() As SWIGTYPE_p_f_p_struct_sox_format_t_unsigned_long__int
            Set(ByVal value As SWIGTYPE_p_f_p_struct_sox_format_t_unsigned_long__int)
                libsoxPINVOKE.sox_format_handler_t_seek_set(swigCPtr, SWIGTYPE_p_f_p_struct_sox_format_t_unsigned_long__int.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_handler_t_seek_get(swigCPtr)
                Dim ret As SWIGTYPE_p_f_p_struct_sox_format_t_unsigned_long__int = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_f_p_struct_sox_format_t_unsigned_long__int(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property write_formats() As SWIGTYPE_p_unsigned_int
            Set(ByVal value As SWIGTYPE_p_unsigned_int)
                libsoxPINVOKE.sox_format_handler_t_write_formats_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_handler_t_write_formats_get(swigCPtr)
                Dim ret As SWIGTYPE_p_unsigned_int = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_unsigned_int(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property write_rates() As SWIGTYPE_p_double
            Set(ByVal value As SWIGTYPE_p_double)
                libsoxPINVOKE.sox_format_handler_t_write_rates_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value))
            End Set
            Get
                Dim cPtr As IntPtr = libsoxPINVOKE.sox_format_handler_t_write_rates_get(swigCPtr)
                Dim ret As SWIGTYPE_p_double = If(cPtr = IntPtr.Zero, Nothing, New SWIGTYPE_p_double(cPtr, False))
                Return ret
            End Get
        End Property

        Public Property priv_size() As UInteger
            Set(ByVal value As UInteger)
                libsoxPINVOKE.sox_format_handler_t_priv_size_set(swigCPtr, value)
            End Set
            Get
                Dim ret As UInteger = libsoxPINVOKE.sox_format_handler_t_priv_size_get(swigCPtr)
                Return ret
            End Get
        End Property

        Public Sub New()
            Me.New(libsoxPINVOKE.new_sox_format_handler_t(), True)
        End Sub

    End Class

End Namespace
