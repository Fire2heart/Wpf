   M S B A M L   `   `   `  ����F  BWpfBinding1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfBinding1WpfBinding1  5   	       WpfBinding1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfBinding1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
         WpfBinding1.Car   car1   Year   Model   Velocity  car2��%�   &	        &	 <       5   
   $
 2016��6/   $	 BMW��6;   $	 220Q�6G     5   
   $
 2010��6!   $ Mercedes��6-   $	 360Q�6>   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   � $��0��6    5      �� 5      �� 5      �� 5      .+�5      �� $��Car 1��6   $��5q�6&   
�����_�.��5      �� 
�������.+�5      �� ��6   ��  �� Source# [   �� Path$ Model� �� UpdateSourceTrigger$ PropertyChanged=��� 5      ��6   �� # [  $
 Year��� 5       ��6   �� # [  $ Velocity�5!      5"      �� 5$      $��1��6   $��Car 2��6$   $��5q�63   
�������.��5%      �� 
�������.+�5&      �� ��6   �� # [ $ Model�$ PropertyChanged=��� 5'      ��6   �� # [ $
 Year��� 5(      ��6   �� # [ $ Velocity�5)      5*      �� 5,      $��2��6   $��
Car 1 View��6$   $��5q�68   
�������.��5-      �� 
�������.+�5.      �� ��6    �� # [  $ Model��� 5/      ��6    �� # [  $
 Year��� 50      ��6    �� # [  $ Velocity�51      52      53      56      57      