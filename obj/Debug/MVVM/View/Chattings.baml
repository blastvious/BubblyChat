   M S B A M L   `   `   `  ����E  ABubblyChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:BubblyChat.MVVM.ViewModelBubblyChat.MVVM.ViewModel  5      $    BubblyChat.MVVM.View.Chattings   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6vm'clr-namespace:BubblyChat.MVVM.ViewModel     5      g cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5         
Page_Style#��[  5      ���#36393f  � DataContext  5      *   $BubblyChat.MVVM.ViewModel.ChattingVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��350 �6   �� 5      $��* �6   .+�5   
   � ���#2f3136 � RowDefinitions 5      �� 5      $��70 �6    �� 5      �� 5      $��80 �6    .+�5       �� $��Contacts��6   $��Center=�5!      $��18(�5"      $��Medium"�5#      
�������$��10 0 0 0q�5%      �� 5&      -   5         ��Name$ Contact��5&      
������ $��0q�5)      $��1��5*        ContactCard#��[ 5+      ��5&   (   �� *
Contacts+ �� SelectedItem 5'      �� *SelectedContact+5+      �� 5/      $��2��6    �� Orientation$ 
Horizontal=�50      ���#292b2f.+�52      ��  �� CornerRadius$ 30��6   $��40��53      $��40��54      ���#3bff6f$��20 0 0 0q�56      �� 57      $��Center=�6   .+�58      �� $��Username��6   
�������$��Medium"�5:      $��12(�5;      $��	0 -5 0 -5q�5<      �� 5=      $��Custom Status��6   
�������$��Medium"�5?      $��12(�5@      $��	0 -5 0 -5q�5A      5B      5C      5D      � 5F   
   $��1��6    5G      �� 5H      $��70 �6    �� 5I      �� 5J      $��80 �6    .+�5M      �� ���#2f3136$��0 0 0 2q�6+   ._�5N      � $��Stretch=�6   $��8q�5O      .+�5P      �� $ 
Horizontal=�6!   .+�5Q      A� $��30��6"   $��30��6.   ��5R      �� 5S   "    �� ImageSource 6-   �� *SelectedContact.ImageSource+5U      �� 5V      
�������$
��Bold"�5X      $��5 0 5 0q�5Y      $��Center=�5Z      ��5V       �� *SelectedContact.Username+5Z      5\      �� 5a      $ 
Horizontal=�6!   $��Right=�5b      .+�5d      �� -   5         ��Name$ btnCall��5d   !     
tboxButton#��[ 62   .��5f      .  (MahApps.Metro.IconPacks.PackIconMaterial  	   Kind$	 Phone=�64   
���   �$��20��6T   $��20��6`   5g      �� 5i      -   5        $ btnVideo��5i   !   #��[ 63   .��5k        $	 Video=�64   
���   �$��20��6T   $��20��6`   5l      5n      5o      5p      �� 5q      
������ $��0q�5s        ChatItem#��[ 5t      $��8 0 0 0q�5u      $��1��5v      ��5q      �� *SelectedContact.Messages+5v      � 5x      $��2��6    5y      �� 5z      �� 5{      $��90 �6'   .+�5}      �� $��1��6   $��50��5~      $��Message @Username��5        
MessageBox#��[ 5�      $��2��5�      �� 5�      $ 
Horizontal=�6   $��Right=�5�      $��1��5�      $��0 0 16 0q�5�      .+�5�      �� -   5        $ btnPlus��5�      #��[ 6.   .��5�        $	 	Paperclip=�60   
���   �$��20��6T   $��20��6_   5�      �� 5�      -   5        $ btnSend��5�      #��[ 6.   ��6R   �� *SendCommand+.��5�        $
	 Send=�60   
���   �$��20��6O   $��20��6Z   5�      5�      5�      5�      5�      5�      