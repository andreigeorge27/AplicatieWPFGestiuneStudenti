   M S B A M L   `   `   `  ���� G  CAplicatiePRC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AplicatiePRCAplicatiePRC      AplicatiePRC.PaginaSport   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:AplicatiePRC       N� Title$  PaginaSport��.��� 
�������$��0,0,0,0q� � RowDefinitions �� $��* �.+��� $��0��$��0,20,0,0q� �� Orientation$ Vertical=�$
��1300�����	#FFFBFBFB.+��� $��SPORT��$��Center=�$��0,20,0,0q����	#FF4F4E54$
��1100��$��60��$��Center=�$��Arial)�$��20(�$
��Bold"�$��Center=�
��������� -    ��Name$ lbSportAles��$��
100,20,0,0q�$
��Left=�$��Ati ales deja: ��$��Arial)�$��20(����	#FF565656$y�Hidden=��� -   $ lbStergeSport��$��	100,0,0,0q�$
��Left=�$2��,Daca doriti sa stergeti sportul apasati pe: ��$��Arial)�$��20(����	#FF565656$y�Hidden=��� -    ��Name$ btnStergeSport��$��	102,0,0,0q�$��20��$��Sterge��$
��Left=�
�������$��0q�
���  ��$y�Hidden=�&   System.Windows.Controls.DataGrid  -     Name$ 
dgSporturi��$��	0,-80,0,0q�$��Center=�   AutoGenerateColumns .  $y�Hidden=�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� $��	btnAplica��-   $��Aplica��0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Denumire Sport��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *DenumireSport+  $	 Locuri Disponibile��
 �� *NumarLocuriDisponibile+