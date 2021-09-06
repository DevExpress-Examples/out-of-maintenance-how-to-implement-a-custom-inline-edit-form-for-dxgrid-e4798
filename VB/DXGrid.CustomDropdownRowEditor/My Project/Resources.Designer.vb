﻿' Developer Express Code Central Example:
' How to implement custom dropdown row editor for DXGrid
' 
' This example demonstrates how to edit grid row using the dropdown panel with
' editors generated automatically based on the underlying row data object. To see
' this approach in action, click the "Edit" hyperlink in the "#" grid column. To
' close dropdown panel click "Edit" again.
' This functionality is achieved by
' creating the attached behavior which generates the necessary DataRowTemplate for
' the grid row. The custom template can also be defined and assigned to the
' GridHelper.CustomTemplate property, so the custom template will be used instead
' the autogenerated template.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4798

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18052
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My.Resources


	''' <summary>
	'''   A strongly-typed resource class, for looking up localized strings, etc.
	''' </summary>
	' This class was auto-generated by the StronglyTypedResourceBuilder
	' class via a tool like ResGen or Visual Studio.
	' To add or remove a member, edit your .ResX file then rerun ResGen
	' with the /str option, or rebuild your VS project.
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	<System.Diagnostics.DebuggerNonUserCodeAttribute()>
	<System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
	Global.Microsoft.VisualBasic.HideModuleNameAttribute()>
	Friend Module Resources

		Private resourceMan As System.Resources.ResourceManager

		Private resourceCulture As System.Globalization.CultureInfo

'		internal Resources()
'		{
'		}

		''' <summary>
		'''   Returns the cached ResourceManager instance used by this class.
		''' </summary>
		<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager() As System.Resources.ResourceManager
			Get
				If (resourceMan Is Nothing) Then
					Dim temp As New System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property

		''' <summary>
		'''   Overrides the current thread's CurrentUICulture property for all
		'''   resource lookups using this strongly typed resource class.
		''' </summary>
		<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
		Friend Property Culture() As System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set(ByVal value As System.Globalization.CultureInfo)
				resourceCulture = value
			End Set
		End Property
	End Module
End Namespace
