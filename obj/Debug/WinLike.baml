   M S B A M L   `   `   `  ����C  ?Hitokoto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HitokotoHitokoto  5   	       Hitokoto.WinLike   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Hitokoto     5   	     � Title$  WinMenu��5   	   $��189.766��6   $��495.03��6*    � AllowsTransparency .  � WindowStyle$
 None=�6S   ���	#00FFFFFF � Topmost .  � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6�   .��5	      � .+�5
   
   ��  �� CornerRadius$ 5��6   $��10q�6"   $��2q�6.   
������� J� Opacity$	 0.8Q�6V    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   ShadowDepth$	 0Q�6#   
   Color$
 	#FF414141��63      
BlurRadius$ 18Q�6E   ._�5      �� 
���   �$	 0.5Q�6(   $��0q�66   $ 5��6A   5      �� 5   
   -   5         ��Name$ lblText��5      $
��Left=�6!   $	��Top=�6<   $��	26,26,0,0q�6T   $��Microsoft YaHei UI Light)�6g   $��15(�6�   
�������.��5      �� -   5         ��Name$ txtText��5      $
��Wrap=�6)   $s��m在此输入要换行的文字，前提是它足够长，并且Label的MaxWidth不足以让它一行显示。��6=   $ 0Q�6r   5      �� 5   
   -   5        $ lblFromC��5      $
��From��6"   $
��Left=�61   $	��Top=�6L   $��	26,72,0,0q�6d   $��15(�6w   
�������$ 0Q�6�   �� 5   
   -   5        $ lblFrom��5      $
��From��6!   $
��Left=�60   $	��Top=�6K   $��
106,72,0,0q�6c   $��15(�6w   
�������$��Microsoft YaHei UI Light)�6�   $ 0Q�6�   �� 5   
   -   5        $ lblCatC��5      $��Category��6!   $
��Left=�64   $	��Top=�6O   $��	26,95,0,0q�6g   $��15(�6z   
�������$ 0Q�6�   �� 5   
   -   5        $ lblCat��5      $��Category��6    $
��Left=�63   $	��Top=�6N   $��
106,95,0,0q�6f   $��15(�6z   
�������$��Microsoft YaHei UI Light)�6�   $ 0Q�6�   �� 5   
   -   5        $ lblHint��5      $��华文中宋)�6!   $5��/轻点上面的句子可以复制哦 (*/ω╲*)��63   $
��Left=�6R   $	��Top=�6m   $��
26,131,0,0q�6�   $��15(�6�   
�������$ 0Q�6�   $	��428��6�   5      5      