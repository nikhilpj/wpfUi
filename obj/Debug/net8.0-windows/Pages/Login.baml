   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp.PagesWpfApp.Pages  5          WpfApp.Pages.Login   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp.Pages     5        N� Title$  Login��5	       N� 
Background �#282c34.��5      �  � Triggers 5   
   :� 5       :� RoutedEvent$ Page.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ 
LoginPanel��6*    �� TargetProperty$ Opacity�5   *    W� From 05   *   	 W� To 163    g� Duration$ 0:0:1.2D�6:   5      5      5      .+�5   
   �� -   5        	 ��Name$	 
LoginPanel��5   /   $	��300��5      
 �� Padding$
 20q�6   
������� �� CornerRadius$ 10��5       J� Opacity$ 0Q�6#   $��Center=�5      $��Center=�6.      ShadowEffect J� Effect# �   5      ._�5   
   �� .+�5      �� $��Login��6   $��22(�6)   $
��Bold"�67   ���#333 �� TextAlignment$ Center=�5    *   $��0 0 0 20q�6A   �� 5"      $��UserName��6   $��0 0 0 10q�6,   ���#5556>   �� 5$      $��0 0 0 10q�5%      $��30��6(   $��5q�64   ���#888$��1q�5&      ��5$      �� *
UserName+ �� UpdateSourceTrigger$ PropertyChanged=�5&      �� 5(      $��Password��6   $��0 0 0 10q�6)   ���#5556;   G� 5*      -   5         G�Name$ passwordBox��5*      $��0 0 0 10q�5+      $��30��6,   $��5q�68   ���#888$��1q�5,      �� 5.      $��Submit��6;   ���#0078d7
�������$��35��5/   (   $��0 0 10 0q�64   $��0q�6F   $��16(�50       � Cursor$
 Hand��6#   ��5.      �� *LoginCommand+��52      �� 53       �� 
TargetType" ��6    .�54      ��  �� Property � �� �� Value �#0078D76;   �� 55       � ��
 �����6;   �� 56       � ��$ 16(�69   �� 57       �@�Cursor$
 Hand��67   �� 58       � ��$ 35��67   �� 59       � ��$ 0q�6@    �� Triggers 5;      P� 5<   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5=   &   ��  � �� �#005a9e6C   5>   #   P� 5?   "    � ��$
 True��6?   . �5@   &   ��  � �� �#003f7f6C   5A   #   5C      5F      �� 5H      
���  ��$��14(�6L   $ Center=�5I      $��0 5 0 0q�63   ��5H      �� *StatusMessage+5I   3   5J      5K      5L      5M      