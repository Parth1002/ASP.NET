   M S B A M L   `   `   `  ����  BehaviorofAnimation$    BehaviorofAnimation.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��450��6)   .��5      � .+�5   
   A� -   5        $��
rectangle1��5   L   $��41��6   $
��Left=�6   $��	10,10,0,0q�69   
���   �$	��Top=�5      $	��100��6*   
�����_�66   �� 5   
   -   5        $��ellipse1��5   B   $
��Left=�6   $��	10,81,0,0q�6/   
���   �$	��100��5	      
������$��31��6!   $	��Top=�6-   �� 5
   
   -   5        $��button1��5
   K   $��23��6   $
��Left=�6   $��	22,0,0,79q�68   $��Bottom=�5      $��75��6   .��6)   Start � Triggers 5      :� 5       :� RoutedEvent$ Button.Click��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ 
rectangle1��6.    �� TargetProperty$ Width�5       W� From$	 100X�6(   	 W� To$	 400X�63    g� Duration$ 0:0:2D�5       g� FillBehavior$ HoldEnd=�6   W� 5      $ ellipse1��6.   $ Width�5      $	 100X�6(   $	 400X�63   $ 0:0:2D�5      $
 Stop=�6   5      5      5      5      5      5      