   M S B A M L   `   `   `  ����M  IMentorJournal_v0.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MentorJournal_v0._1MentorJournal_v0._1  5   	   $    MentorJournal_v0._1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:MentorJournal_v0._1     5   	   b ^SharpVectors.Converters.Wpf, Version=1.8.4.1, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  5   	   $	��800��5	   	   $
��1200��5
   	     � WindowStyle$
  None=�5   	   
������  � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �� ���	#ffdadada �� CornerRadius$ 20��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��10* �6#   �� 5      $
��100* �6#    � RowDefinitions 5      �� 5      $��3* �6    �� 5      $	��20* �6    .+�5      �� $��0��6   $��0��5      $ 20��5       $��15,15,15,15q�5!      
������� J� Effect 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%         
BlurRadius$ 10Q�6'      ShadowDepth$ 0Q�67   	   Color$
	 Gray��6G   ._�5(      �� -   5        
 ��Name$
 profole��5(      $��/asset/user.png��5)      $��50��5*      $��50��5+      5,      5.      �� 50      -   5         ��Name$ 
exitButton��50      $��X��51      $��0��52      $��1��53      $	��Top=�54      $��Right=�55      $��	0,20,20,0q�56      $��32��6A   $��41��6M   �� 58      $ 20��6   
�������$��0��5:      $��1��5;      $��Center=�5<      $��	15,0,15,0q�5=      $	��600��5>      $	��600��6%    5@        5A      $ 10Q�6'   $ 0Q�67   $
	 Gray��6G   ._�5D      �� $��Hidden=�6   .��5F      �� -   5         ��Name$ sideMenu��5F   !   .+�5H      �� -   5        $
 socialPassport��5H       $��/asset/socialPassport.png��68   $��50��6[   $��50��6f   $��	0 15 0 15q�6r    � ToolTip 5I      �� 5J   "   '%Социальный пасспорт5L   #   5N      �� 5P      -   5        $
 	dormitory��5P       $��/asset/dormitory.png��63   $��50��6Q   $��50��6\   $��0 0 0 15q�6h    5Q      �� 5R   "   *(Студенты из общежития5T   #   5V      �� 5X      -   5        $
 parrentConference��5X       $"��/asset/parrentConference.png��6;   $��50��6a   $��50��6l   $��0 0 0 15q�6x    5Y      �� 5Z   "   ><Протоколы родительских собраний5\   #   5^      �� 5`      -   5        $
 wachingList��5`       $��/asset/wachingList.png��65   $��50��6U   $��50��6`   $��0 0 0 15q�6l    5a      �� 5b   "   =;Лист наблюдений(характеристики)5d   #   5f      �� 5h      -   5        $
 visitedList��5h       $��/asset/visitedList.png��65   $��50��6U   $��50��6`   $��0 0 0 15q�6l    5i      �� 5j   "   ECПосещение студентами классных часов5l   #   5n      �� 5p      -	   5        $
 events��5p       $��/asset/event.png��60   $��50��6J   $��50��6U   $��0 0 0 15q�6a    5q      �� 5r   "   #!Планы мероприятий5t   #   5v      �� 5x      -
   5        $
 hobbies��5x       $��/asset/hobbies.png��61   $��50��6M   $��50��6X   $��0 0 0 15q�6d    5y      �� 5z   "   )'Внеучебная занятость5|   #   5~      �� 5�      -   5        $
 	activists��5�       $��/asset/activist.png��63   $��50��6P   $��50��6[   $��0 0 0 15q�6g    5�      �� 5�   "   !Активисты группы5�   #   5�      �� 5�      -   5        $
 individualWork��5�       $��/asset/individualWork.png��68   $��50��6[   $��50��6f   $��0 0 0 15q�6r    5�      �� 5�   "   ZXИндивидуальная работа со студентами/родителями5�   #   5�      5�      5�      5�       � 5�      -   5          �Name$ 	mainFrame��5�      $��1��5�      $��1��5�      $��Center=�5�      $��Center=�5�      $	��600��5�      $
��1060��5�      $	��600��5�        � NavigationUIVisibility$ Hidden=�5�      5�      5�      5�      