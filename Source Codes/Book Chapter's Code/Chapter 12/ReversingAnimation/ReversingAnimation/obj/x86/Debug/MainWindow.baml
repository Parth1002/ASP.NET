   M S B A M L   `   `   `  ����  ReversingAnimation#    ReversingAnimation.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��300��6)   .��5      �� .+�5   
   �� -   5        $��
rectangle1��5       $��43��6   
���   �$��88��6A   
���  ��6L   �� 5   
   -   5        $��
rectangle2��5       $��43��6   
���   �$��88��6A   
��� ���6L   �� 5   
   -   5        $��button1��5      $��23��6   $	��166��6,   .��68   StartAnimation � Triggers 5
      :� 5       :� RoutedEvent$ Button.Click��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ 
rectangle1��6.    �� TargetProperty$ Width�5       g� Duration$ 0:0:2D�6'    W� From$ 88X�68   	 W� To$	 250X�5       g� AutoReverse .  6   W� 5      $ 
rectangle2��6.   $ Width�5      $ 0:0:2D�6(   $ 88X�69   $	 250X�5       . 6   5      5      5      5      5      5      