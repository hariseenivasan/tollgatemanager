   M S B A M L   `   `   `  ����M  Itollgatemanagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:tollgatemanagementtollgatemanagement  5   	   #    tollgatemanagement.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:tollgatemanagement     5   	   -   5          �Name$  	wndwStart��5   	    � Title$ Toll Management System��5   	   $	��350��6(   $	��525��65    � 	Resources 5	      )   #tollgatemanagement.Database1DataSet   database1DataSet  employeeViewSource �� Source �� Source��%Y   &	        &	      7     5
   
   6!   �� 5   
    6:   �� *
Employee+8   5      .��5      � .+�5   
   �� $��Toll Plaza Management��6   $��Center=�60   $��142,41,106.4,0q�6M   $	��Top=�6e   $��Center=�6}   $��24(�6�   $	��270��6�   � 5   
   -   5         �Name$ grid1��5       � DataContext# [ 6   $
��Left=�6P   $��169,111,0,0q�6k   $	��Top=�6�    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    .+�5      �� $��
User Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��0��6_   $��Center=�6l   �� 5      -   5        	 ��Name$	 txtUserName��5      $��1��6+   $
��Left=�6;   $��24��6V   $��2.6,4,-0.2,4q�6b   $��0��6x   $��Center=�6�   $	��124��6  ��6�   �� *
username+
 �� Mode$
 TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6  5      � 5   
   -   5        $ grid2��5      # [ 6   $
��Left=�6P   $��179,148,0,0q�6k   $	��Top=�6�    5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5       $
��Auto �6    .+�5"      �� $��
Password: ��6   $��0��6)   $
��Left=�69   $��3q�6T   $��0��6_   $��Center=�6l   G� 5#      -   5         G�Name$ txtPassword��5#      $
��Left=�6/   $��24��6J   $��69,4,0,4q�6V   $��0��6h   $��Center=�6v   $	��126��6�   $��2��6�   5$      �� 5%   
   -   5         ��Name$ 	btnSignIn��5%      $��Sign In��6$   $
��Left=�66   $��190,185,0,0q�6Q   $	��Top=�6f   $	��184��6~   6�   5'      5(      