Imports System.Runtime.InteropServices

' ----------------------------------------------------------------------------
' * This file was automatically generated by SWIG (http://www.swig.org).
' * Version 2.0.10
' *
' * Do not make changes to this file unless you know what you are doing--modify
' * the SWIG interface file instead.
' * ----------------------------------------------------------------------------- 

Namespace swig


    Public Class SWIGTYPE_p_f_p_struct_sox_format_t__int
        Private swigCPtr As HandleRef

        Friend Sub New(ByVal cPtr As IntPtr, ByVal futureUse As Boolean)
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Protected Sub New()
            swigCPtr = New HandleRef(Nothing, IntPtr.Zero)
        End Sub

        Friend Shared Function getCPtr(ByVal obj As SWIGTYPE_p_f_p_struct_sox_format_t__int) As HandleRef
            Return If(obj Is Nothing, New HandleRef(Nothing, IntPtr.Zero), obj.swigCPtr)
        End Function

        Public Sub New(ByVal cPtr As IntPtr)
            swigCPtr = New HandleRef(Me, cPtr)
        End Sub

        Public Function GetswigCPtr() As IntPtr
            Return swigCPtr.Handle
        End Function

    End Class

End Namespace
