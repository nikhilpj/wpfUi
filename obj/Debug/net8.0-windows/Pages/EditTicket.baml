   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp.PagesWpfApp.Pages  5          WpfApp.Pages.EditTicket   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp.Pages     5        N� Title$  
EditTicket��5	       N� 
Background �#282C34.��5      �  � Triggers 5   
   :� 5       :� RoutedEvent$ Page.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ 	EditPanel��6*    �� TargetProperty$ Opacity�5   *    W� From 05   *   	 W� To 163    g� Duration$ 0:0:1.2D�6:   5      5      5      .+�56   
   �� $��← Home��6   $
��Left=�57      $	��Top=�6,   $��20q�6D   $
��10,5q�58      
������ 
�������$��14(�59      	 � Cursor$
	 Hand��6   ��56   "   �� *NavigateToMainCommand+��5:      �� 5;      
 �� 
TargetType"
 ��6   .�5<      ��  �� Property � �� �� Value
 �����63   �� 5=       � ��$ 14(�61   �� 5>       �@�Cursor$
 Hand��6/    �� Triggers 5?      P� 5@       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5A      ��  � ��
 �����6;   5B      5D      5F      �� 5I   
   -   5         ��Name$ 	EditPanel��5J   /   $	��350��5I       �� Padding$ 20q�6   
������� �� CornerRadius$ 10��5J       J� Opacity$ 0Q�6#   $��Center=�5K      $��Center=�6.   ._�5N      �� .+�5P      �� $��Edit Ticket��6   $��22(�6/   $
��Bold"�6=   ���#333 �� TextAlignment$ Center=�5Q   .   $��0 0 0 20q�6E   �� 5S      $��	Ticket ID��6   $
��Bold"�6-   ���#5556?   �� 5T      $��16(�67   ���#0078D7$
��Bold"�5U      $��0 0 0 10q�6.   ��5T      �� *	Ticket.Id+5U   .   �� 5X      $��Title��6   $
��Bold"�6)   ���#5556;   �� 5Y      $��16(�6:   ���#333$��0 0 0 10q�5Z      ��5Y      �� *Ticket.Title+5Z      �� 5]      $��Status��6   $
��Bold"�6*   ���#555$��
10 10 0 10q�6N   �� 5^       �� Orientation$ Vertical=�6   $��0 0 0 10q�64   .+�5_      �� $
��Open��6   
���   � d� 	IsChecked 6.   �� *IsOpen+ �� Mode$ TwoWay=�{�5`      �� *IsOpenEnabled+6C   �� 5a      $��In Progress��6   
���   � 65   �� *IsInProgress+$ TwoWay=�5b      �� 5c      $��Closed��6   
���   � 60   �� *
IsClosed+$ TwoWay=�5d      5e      �� 5h      $
��Save��6   $	��100��5i      $��35��6%   $��	10 20 0 0q�61   ���#0078D7
�������$��0q�5k      $��16(�6-   $
	 Hand��6;   $��Center=�5l      ��5h   (   �� *SaveCommand+��5n      �� 5o      "
 ��6    .�5p      ��  � �� �#0078D76;   �� 5q       � ��
 �����6;   �� 5r       � ��$ 16(�69   �� 5s       �@�Cursor$
 Hand��67   �� 5t       � ��$ 35��67   �� 5u       � ��$ 0q�6@    5v      P� 5w   "    �@J�IsMouseOver$
 True��6A   . �5x   &   ��  � �� �#005a9e6C   5y   #   P� 5z   "    � ��$
 True��6?   . �5{   &   ��  � �� �#003f7f6C   5|   #   5~      5�      5�      5�      5�      5�      