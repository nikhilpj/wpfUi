   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp.PagesWpfApp.Pages  5          WpfApp.Pages.AddTicket   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp.Pages     5        N� Title$  	AddTicket��5	       N� 
Background �#282c34.��5      �  � Triggers 5   
   :� 5       :� RoutedEvent$ Page.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ AddPanel��6*    �� TargetProperty$ Opacity�5   *    W� From 05   *   	 W� To 163    g� Duration$ 0:0:1.2D�6:   5      5      5      .+�5   
   �� $��← Home��6   $
��Left=�5   
   $	��Top=�6%   $��20q�6=   $
��10,5q�5   
   
������ 
�������$��14(�5   
   	 � Cursor$
	 Hand��6   ��5   "   �� *NavigateToMainCommand+��5      �� 5      
 �� 
TargetType"
 ��6   .�5      ��  �� Property � �� �� Value
 �����63   �� 5        � ��$ 14(�61   �� 5!       �@�Cursor$
 Hand��6/    �� Triggers 5"      P� 5#       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5$      ��  � ��
 �����6;   5%      5'      5)      �� 5+   
   -   5         ��Name$ AddPanel��5,   /   $	��350��5+       �� Padding$ 20q�6   
������� �� CornerRadius$ 10��5,       J� Opacity$ 0Q�6#   $��Center=�5-      $��Center=�6.   ._�5/   
   �� .+�51      �� $��Create New Ticket��6   $��22(�65   $
��Bold"�6C   ���#333 �� TextAlignment$ Center=�52   .   $��0 0 0 20q�6E   �� 54      $��Title��6   $
��Bold"�6)   ���#5556;   �� 56      $��0 0 0 10q�57      $��30��6(   $��5q�64   ���#888$��1q�58      ��56      �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=�58      �� 59      $��Details��6   $
��Bold"�6+   ���#555$��10 0 0 0q�5:      �� 5;      $��0 0 0 10q�6\   $��60��5<      $��5q�6&   ���#888$��1q�5=       �� AcceptsReturn$
 True��6.    �� TextWrapping$
 Wrap=�6C   ��5;      �� *Description+$ PropertyChanged=�5=   C   �� 5>      $��Submit��6   $��	10 20 0 0q�5?      $	��120��6(   $��35��64   ���#0078D7
�������$��0q�5A      $��16(�6-   $
	 Hand��6;   $��Center=�5B      ��5>   *   �� *SubmitCommand+��5D      �� 5E      "
 ��6    .�5F      ��  � �� �#0078D76;   �� 5G       � ��
 �����6;   �� 5H       � ��$ 16(�69   �� 5I       �@�Cursor$
 Hand��67   �� 5J       � ��$ 35��67   �� 5K       � ��$ 0q�6@    5L      P� 5M   "    �@J�IsMouseOver$
 True��6A   . �5N   &   ��  � �� �#005a9e6C   5O   #   P� 5P   "    � ��$
 True��6?   . �5Q   &   ��  � �� �#003f7f6C   5R   #   5T      5V      5W      5X      5Y      5Z      