   M S B A M L   `   `   `  ����M  Itollgatemanagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:tollgatemanagementtollgatemanagement  5   	   !    tollgatemanagement.Employee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:tollgatemanagement     5   	   -   5          �Name$  wndwCollector��5   	    � Title$ 	Collector��5   	   $��533.909��6   $��886.248��6,    � 	Resources 5	      )   #tollgatemanagement.Database1DataSet   database1DataSet  viewViewSource �� Source �� Source  passReciptDetailsViewSource  tollAreaViewSource  passTypeViewSource  vAPTableViewSource  vehicleTypeViewSource��%�  &	        &	      7   &	 =     7   &	 t     7   &	 �     7   &	 �     7   &	 �     7     5
   
   6!   �� 5   
    66   �� *View+8   �� 5   
    6C   �� *PassReciptDetails+8   �� 5   
    6:   �� *
TollArea+8   �� 5   
    6:   �� *
PassType+8   �� 5   
    6:   �� *
VAPTable+8   �� 5   
    6=   �� *VehicleType+8   5      .��5      �  � DataContext# [ 6   .+�5   
   � $��20,17,10,10q�6   .+�5      � $��	615,0,0,0q�6   $
��Left=�6&   $	��235��6A   .+�5      �� $��Number Plate��6   $
��Left=�6/   $��	0,0,0,181q�6J   $��Bottom=�6]   $��Right=�6x   �� 5      -   5         ��Name$ txtNumberPlate��5      $
��Left=�62   $��23��6M   $��
86,0,0,182q�6Y    �� TextWrapping$
 Wrap=�6m   $��Bottom=�6�   $	��120��6�   �� 5      $��	Pass Type��6   $
��Left=�6,   $��
20,0,0,155q�6G   $��Bottom=�6[   �� 5      $��Vehicle Type��6   $
��Left=�6/   $��	6,0,0,116q�6J   $��Bottom=�6]   �� 5      $��	Total Rs:��6   $
��Left=�6,   $��	22,0,0,69q�6G   $��Bottom=�6Z   $��36��6u   $��18(�6�   $
��Bold"�6�   �� 5      -   5        $ txtPrice��5      $
��Left=�6,   $��33��6G   $��
104,0,0,69q�6S   $
 Wrap=�6h   $��Bottom=�6|   $	��102��6�   {�.  $��18(�6�   $
��Bold"�6�    �� 
IsReadOnly . 	 �� IsUndoEnabled	 .  
���  ��6  �� 5      -   5        
 ��Name$
 tollAreaComboBox��5       �� DisplayMemberPath$ Locality��65   $��
81,0,0,265q�6�    �� SelectedValuePath$ 
PostalCode��6�   $��29��6�   $��Bottom=�6�   $
��Left=�6�   $	��138��6
  ��6R   �� # [ ��5      �� 5      .R�5      $� 5      5!      �� 5"      -   5        $
 passTypeComboBox��5"      $ PassType��65   $��
88,0,0,147q�6�   $ Id��6�   $
��Left=�6�   $	��131��6  $��30��6  $��Bottom=�6(  ��6R   �� # [ ��5#      �� 5$      .R�5%      $� 5&      5(      �� 5)      -   5         ��Name$ btnNxt��5)      $��Next Vehicle��6)   $��0,0,11,0q�6@   $��Bottom=�6R   $��55��6m   $��Right=�6�   $	��125��6�   �� 5*      -   5        $
 vehicleTypeComboBox��5*      $ VehicleType��68   $��
88,0,0,107q�6�   $ Id��6�   $
��Left=�6�   $	��131��6�   $��35��6�   $��Bottom=�6�   ��6X   �� # [ ��5+      �� 5,      .R�5-      $� 5.      50      �� 52      -   5        $ 	btnLogout��52      $��Log Out��6,   $
��Left=�6>   $��117,0,0,447q�6Y   $��Bottom=�6n   $	��102��6�   $��20��6�   6�   53      &   System.Windows.Controls.DataGrid  54      -	   5          Name$ passReciptDetailsDataGrid��54         AutoGenerateColumns .     EnableRowVirtualization . $��0,0,0,12q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $
��Left=�6�   $	��582��6�   ��6u   ��    Columns 55      4  .System.Windows.Controls.DataGridTemplateColumn  56      -
   5        passIdColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Pass Id��56   C      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6T      CellTemplate 57      �� 58      .R�59   "   �� ��6(   �� *PassId+5:      5<        5=      -   5        
dateColumn��$
 Date��5=   A   $ SizeToHeader 6O    5>      �� 5?      .R�5@   "   �� ��6(   �� *Date+5A      5C        5D      -   5        numberPlateColumn��$ Number Plate��5D   H   $ SizeToHeader 6^    5E      �� 5F      .R�5G   "   �� ��6(   �� *NumberPlate+5H      5J        5K      -   5        expiryColumn��$ Expiry��5K   C      
IsReadOnly . $ SizeToHeader 6e    5L      �� 5M      .R�5N   "   �� ��6(   �� *Expiry+5O      5Q        5R      -   5        isExpiredColumn��$ 
Is Expired��5R   F    . $ SizeToHeader 6l    5S      �� 5T      .R�5U   "   �� ��6(   �� *	IsExpired+5V      5X        5Y      -   5        vehicleTypeColumn��$ Vehicle Type��5Y   H   $ SizeToHeader 6^    5Z      �� 5[      .R�5\   "   �� ��6(   �� *VehicleType+5]      5_        5`      -   5        priceColumn��$ Price��5`   B   $ SizeToHeader 6Q    5a      �� 5b      .R�5c   "   �� ��6(   �� *Price+5d      5f        5g      -   5        passTypeColumn��$ 	Pass Type��5g   E   $ SizeToHeader 6X    5h      �� 5i      .R�5j   "   �� ��6(   �� *
PassType+5k      5m        5n      -   5        postalCodeColumn��$ Postal Code��5n   G   $ SizeToHeader 6\    5o      �� 5p      .R�5q   "   �� ��6(   �� *
PostalCode+5r      5t        5u      -   5        localityColumn��$ Locality��5u   E   $ SizeToHeader 6W    5v      �� 5w      .R�5x   "   �� ��6(   �� *
Locality+5y      5{        5|      -   5        
cityColumn��$
 City��5|   A   $ SizeToHeader 6O    5}      �� 5~      .R�5   "   �� ��6(   �� *City+5�      5�        5�      -   5        stateColumn��$ State��5�   B   $ SizeToHeader 6Q    5�      �� 5�      .R�5�   "   �� ��6(   �� *State+5�      5�      5�      5�      5�      5�      