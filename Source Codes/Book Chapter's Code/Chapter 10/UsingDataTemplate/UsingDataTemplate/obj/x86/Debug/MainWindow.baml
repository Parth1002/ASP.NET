   M S B A M L   `   `   `  ����  UsingDataTemplate"    UsingDataTemplate.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5         myTasks � XPath��%�   &	        � 5   
   $ 
Tasks/Task��6*   .��5      ��<Tasks xmlns="">
                    <Task Name="Groceries" />
                    <Task Name="Laundary" />
                    <Task Name="Mail" />
                </Tasks>        5      5      .��5      �� $��Stretch=�6   ��5   
   ��  �� Source# [  ��5   
   �� 5       � 	Resources 5       �� 
TargetType �� Property �� Value��%z   '��       �� 5      " ��6   .�5      ��  � ��$ 18(�65   �� 5       � ��$ Center=�6@   5      5      .R�5      � .+�5      A� 
�������6   �� 5      .+�5      �� $��3,3,3,0q�6$   ��65   ��  �� XPath$ @Name���� 5      $��3,0,3,7q�6$   ��65   �� $ 	@Priority��5      5       5!      ��5#   
   �� 5$      .�5%      ��  � ��$	 100��62   �� 5&       � ��$ 5q�63   5'      5)      5*      