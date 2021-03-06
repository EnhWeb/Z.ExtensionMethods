
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_167

	''' <summary>
	'''     Divides two specified  values.
	''' </summary>
	''' <param name="d1">The dividend.</param>
	''' <param name="d2">The divisor.</param>
	''' <returns>The result of dividing  by .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Divide(d1 As [Decimal], d2 As [Decimal]) As [Decimal]
		Return [Decimal].Divide(d1, d2)
	End Function
End Module


