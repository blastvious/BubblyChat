   M S B A M L   `   `   `  ����E  ABubblyChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:BubblyChat.MVVM.ViewModelBubblyChat.MVVM.ViewModel  5   	   1clr-namespace:BubblyChat.CoreBubblyChat.Core  5   	   'clr-namespace:BubblyChat
BubblyChat  5	   	       BubblyChat.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6vm'clr-namespace:BubblyChat.MVVM.ViewModel     5   	   g cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   *Menuclr-namespace:BubblyChat.Core   5   	   &localclr-namespace:BubblyChat   5	   	   $	��770��5
      $
��1250��5   	     � AllowsTransparency  .  � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   ���#36393F � 
ResizeMode$ CanResizeWithGrip=�5   	    � DataContext 5      ,  &BubblyChat.MVVM.ViewModel.NavigationVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��220 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5"   
   �� -   5        $��0��5"      $��2��5#      ���#6145e3$��Stretch=�5&      $��Stretch=�5'      ._�5(      � $��Stretch=�6   .+�5)      �� $��Bubbly Chat��6   
�������$��16(�5+      $��SemiBold"�5,      $
��Left=�5-      $��Center=�5.      �� 50       �� Orientation$ 
Horizontal=�6   $��Right=�51      .+�52      �� -   5         ��Name$ btnMinimize��52         
tboxButton#��[  53      .��56      .  (MahApps.Metro.IconPacks.PackIconMaterial  	   Kind$	 WindowMinimize=�60   
���   ����#6145e358   0   59      �� 5:      -   5        $ btnMaximize��5:      #��[  5;      .��5>        $	 WindowMaximize=�60   
���   ����#6145e35@   0   5A      �� 5B      -   5        $ btnClose��5B      #��[  5C      .��5F        $	 WindowClose=�60   
���   ����#6145e35H   0   5I      5K      5L      5P      � 5R   
   $��1��6   $
��Left=�5S      $	��218��5T      .+�5U      �� ���#6f50ff6   �� 5V      $	��220��6   $	��600��5W      .+�5Y         BubblyChat.Core.Btn    BtnStyleNavigate#��[ 6   
 d� 	IsChecked$

 TrueY�5[      ��5Z      �� *HomeCommand+.��5\      � .+�5]        $	 HomeOutline=�60   $��30��5^   0   $��30��5_   0   
�������$��Center=�5a   0   $��19,0,0,0q�5b   0   �� 5c      $
��Home��6$     
Text_Style#��[ 60   5d      5e        5g      #��[ 6   $
 FalseY�5i      ��5h      �� *ChatCommand+.��5j      � .+�5k        $	 MessageOutline=�60   $��30��5l   0   $��30��5m   0   
�������$��Center=�5o   0   $��19,0,0,0q�5p   0   �� 5q      $
��Chat��6$   #��[ 60   5r      5s      5u      5v      � 5w   
   $��1��6   $��1��6   .+�5x      �� -   5         ��Name$
 Page��5x      ��6+   �� *CurrentView+5y      5z      5{      