   M S B A M L   `   `   `  ����K  GCommandOrderDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CommandOrderDemoCommandOrderDemo  5   	   !    CommandOrderDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CommandOrderDemo     5   	     � Title$  Orders��5   	   $	��350��6   $	��525��6%    � 	Resources 5	         OrderTemplate �� Path �� Mode(  "System.Windows.Controls.DatePicker   SelectedDate��%A  &	        �� 5
   
   .R�5      � 
�������.+�5      �� $��2q�60   
��� � ���6   �� *Id+6;   �� 5      $��2q�69   ��6   �� $ Customer�69   �� 5      $��2q�6C   ��6   �� $ Price�$ TwoWay=�6C     5       6   �� $
 Date�$ TwoWay=�5      5      5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.New��5      6Z     5   
   -   5        $ ApplicationCommands.Open��5      6\     5   
   -   5        $ ApplicationCommands.Save��5      6\     5   
   -   5        $! local:CustomCommands.Insert��5      6a     5   
   -   5        $! local:CustomCommands.Remove��5      6a     5   
   -   5        $ local:CustomCommands.Exit��5      6_   .��5      ]� .+�5   
   o� $	��Top=�6   .@�5       m� $
��File��6   .@�5!      m�  m� Command$ ApplicationCommands.New��6   6?   m� 5"      $ ApplicationCommands.Open��6   6@   m� 5#      $ ApplicationCommands.Save��6   6@   �� 5$      m� 5%      $
��Exit��6   6+   5&      m� 5(      $
��Edit��6   .@�5)      m� $! local:CustomCommands.Insert��6   6C   m� 5*      $! local:CustomCommands.Remove��6   6C   5+      5,      `� 5.   
   $	��Top=�6   .�5/      c� .@�50      �� $��ApplicationCommands.New��6   6=   �� 51      $��ApplicationCommands.Open��6   6>   �� 52      $��ApplicationCommands.Save��6   6>   53      c� 54      .@�55      �� $!��local:CustomCommands.Insert��6   6A   �� 56      $!��local:CustomCommands.Remove��6   6A   57      58      � 5:   
    � ColumnDefinitions 5;      �� 5<      $��4* �6#   60   �� 5=      $��* �6#   6/   .+�5?      �� -   5        $��	lbxOrders��5?      #��[  5@      5A      �� 5C      $��1��6   $��Bottom=�6)   5E      5F      5G      5I      