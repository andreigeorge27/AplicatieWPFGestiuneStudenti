   M S B A M L   `   `   `  ���� G  CAplicatiePRC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AplicatiePRCAplicatiePRC      AplicatiePRC.PaginaNote   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:AplicatiePRC       N� Title$  
PaginaNote��.��� 
�������$��0,0,0,0q� � RowDefinitions �� $	��250 ��� $��* �.+��� $��0��$��0,30,0,0q� �� Orientation$ Vertical=�$
��1300��$	��220�����	#FFFBFBFB.+��� -    ��Name$ lb��$��AN UNIVERSITAR��$��Center=�$��0,20,0,0q����	#FF4F4E54$
��1100��$��60��$��Center=�$��Arial)�$��20(�$
��Bold"�$��Center=�
��������� $	��An:��$��
100,20,0,0q��� -    ��Name$ cmbAni��$��	100,0,0,0q�$	��200��$
��Left=��� $��	Semestru:��$��
100,10,0,0q��� -   $ cmbSemestru��$��	100,0,0,0q�$	��200��$
��Left=��� $��1��$��0,20,0,0q�$ Vertical=�$
��1300�����	#FFFBFBFB.+��� $��NOTELE MELE��$��Center=�$��0,20,0,0q����	#FF4F4E54$
��1100��$��60��$��Center=�$��Arial)�$��20(�$
��Bold"�$��Center=�
�������&   System.Windows.Controls.DataGrid  -     Name$ dgNote��$��0,20,0,0q�$��Center=�   AutoGenerateColumns .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Denumire Curs��1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *Cur.DenumireCurs+  $
 Nota��	 �� *Nota1+  $ Semestru��	 �� *Cur.Semestru+  $ Numar de Credite��	 �� *Cur.NumarCredite+