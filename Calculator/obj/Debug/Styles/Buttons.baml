   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Calculator.StylesCalculator.Styles  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   FocusVisual  �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  BaseButtonStyle �� 
TargetType  Button.Static.Background  Button.Static.Border �� 
TargetType ��Name ��Name �� Triggers	 P� Property
 P� Value  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground   BaseWindowControlButtonStyle �� BasedOn'   !System.Windows.Shell.WindowChrome ) %WindowControlButton.Static.Background % !WindowControlButton.Static.Border , (WindowControlButton.MouseOver.Background ( $WindowControlButton.MouseOver.Border * &WindowControlButton.Pressed.Background & "WindowControlButton.Pressed.Border ! WindowCloseControlButtonStyle 1 -WindowCloseControlButton.MouseOver.Background - )WindowCloseControlButton.MouseOver.Border 1 -WindowCloseControlButton.MouseOver.Foreground / +WindowCloseControlButton.Pressed.Background + 'WindowCloseControlButton.Pressed.Border / +WindowCloseControlButton.Pressed.Foreground  BaseTopPanelButtonStyle $  TopPanelButton.Static.Background   TopPanelButton.Static.Border & "TopPanelButton.Disabled.Background " TopPanelButton.Disabled.Border & "TopPanelButton.Disabled.Foreground  NavigationButtonStyle )  %NavigationButton.MouseOver.Background %! !NavigationButton.MouseOver.Border '" #NavigationButton.Pressed.Background ## NavigationButton.Pressed.Border $ MemoryButtonStyle "% MemoryButton.Static.Background & MemoryButton.Static.Border $'  MemoryButton.Disabled.Background  ( MemoryButton.Disabled.Border $)  MemoryButton.Disabled.Foreground * NumberButtonStyle "+ NumberButton.Static.Background , NumberButton.Static.Border $-  NumberButton.Disabled.Background  . NumberButton.Disabled.Border $/  NumberButton.Disabled.Foreground 0 BaseOperationButtonStyle %1 !OperationButton.Static.Background !2 OperationButton.Static.Border 3 CalcMDL2 "4 ArithmeticOperationButtonStyle 5 ResultButtonStyle "6 ResultButton.Static.Background 7 ResultButton.Static.Border %8 !ResultButton.MouseOver.Background !9 ResultButton.MouseOver.Border #: ResultButton.Pressed.Background ; ResultButton.Pressed.Border�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      )localclr-namespace:Calculator.Styles  5      %!  &	        &	 �     7   7  7  7  7  7  7  7  7 	 7 
 &	 �    7  7  7  7  7  7  7  &	     7  7  7  7  7  7  7  &	 W    7  7  7  7  7  7  &	 �	    7  7   7 ! 7 " 7 # &	$ �
    7  7 % 7 & 7 ' 7 ( 7 ) &	* ?    7  7 + 7 , 7 - 7 . 7 / &	0 �    7  7 1 7 2 7 3 &	4 �    7 0 &	5     7  7 6 7 7 7 8 7 9 7 : 7 ; �� 5      .�5   
   ��   � �� 5      �� 5      .R�5	      �� $��2q�6     . #��� ��6F   $��1��6�   $	 1 2R�6�   5
      5      5      �� 5      " ��6$   �5   
   �� 5        �@�FocusVisualStyle8   61   �� 5        � ��$ 1q�6'   �� 5        � ��8  6+   �� 5        � ��8  6,   �� 5        � ��$ 1q�60   �� 5        � ��# � ��6+   �� 5        � ��$ Center=�6;   �� 5        � ��$ Center=�69   �� 5        � �� 5      �� 5       " ��6&   .R�5!      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5"      �� $ contentPresenter��5#   !   |�.  #��z��5%   !   #��z��5&   !   ��. # z 5(   !   #��z��5)   !   5*      5+      5-       5/   
   P� 50      	 �@��IsDefaulted
 . . �51      ��   � ��# � ��60   52      P� 53      	 �@J�IsMouseOver
 . . �54      ��   � ��8  6/   �� 55        � ��8  60   56      P� 57      	 � ��
 . . �58      ��   � ��8  6/   �� 59        � ��8  60   5:      P� 5;      	 � {�
 .  . �5<      ��   � ��8  6/   �� 5=        � ��8  60   �� 5>        � ��8 	 6;   5?      5A      �� 5E      8   " ��6\   �5F   
   �� 5G         �@  IsHitTestVisibleInChrome . 6F   �� 5H        � ��$ 0q�6'   �� 5I        � ��$ 46��6&   �� 5K        � ��8  6+   �� 5L        � ��8  6,   �� 5N        � ��$ Microsoft YaHei Light)�6+    5P   
   P� 5Q      	 �@J�IsMouseOver
 . . �5R      ��   � ��8  6/   �� 5S        � ��8  60   5T      P� 5U      	 � ��
 . . �5V      ��   � ��8  6/   �� 5W        � ��8  60   5X      5Z      �� 5]      8   " ��6j    5^   
   P� 5_      	 �@J�IsMouseOver
 . . �5`      ��   � ��8  6/   �� 5a        � ��8  60   �� 5b        � ��8  6;   5c      P� 5d      	 � ��
 . . �5e      ��   � ��8  6/   �� 5f        � ��8  60   �� 5g        � ��8  6;   5h      5j      �� 5o      8   " ��6W   �5p   
   �� 5q        � ��8  6+   �� 5r        � ��8  6,   �� 5t        � ��$ 0q�6'   �� 5u        � ��$ 40��6&    5w   
   P� 5x      	 � {�
 .  . �5y      ��   � ��8  6/   �� 5z        � ��8  60   �� 5{        � ��8  6;   5|      5~      �� 5�      8   " ��6]    5�   
   P� 5�      	 �@J�IsMouseOver
 . . �5�      ��   � ��8  6/   �� 5�        � ��8  60   5�      P� 5�      	 � ��
 . . �5�      ��   � ��8  6/   �� 5�        � ��8  60   5�      5�      �� 5�      8   " ��6Q   �5�   
   �� 5�        � ��8  6+   �� 5�        � ��8  6,   �� 5�        � ��$ Microsoft JhengHei)�6+   �� 5�        � ��$
 Bold"�6+   �� 5�        � ��$ 78��6)    5�   
   P� 5�      	 � {�
 .  . �5�      ��   � ��8  6/   �� 5�        � ��8  60   �� 5�        � ��8  6;   5�      5�      �� 5�      8   " ��6Q   �5�   
   �� 5�        � ��8  6+   �� 5�        � ��8  6,   �� 5�        � ��$ 18(�6)   �� 5�        � ��$ Microsoft JhengHei UI)�6+   �� 5�        � ��$
 Bold"�6+    5�   
   P� 5�      	 � {�
 .  . �5�      ��   � ��8  6/   �� 5�        � ��8  60   �� 5�        � ��8  6;   5�      5�      �� 5�      8   " ��6X   �5�   
   �� 5�        � ��8  6+   �� 5�        � ��8  6,   �� 5�        � ��$ 14(�6)   �� 5�        � ��8  6+   5�      �� 5�      8   " ��6g   �5�   
   �� 5�        � ��$ 27(�6)   �� 5�        � ��$ Microsoft YaHei Light)�6+   5�      �� 5�      8   " ��6Q   �5�   
   �� 5�        � ��8  6+   �� 5�        � ��8  6,   �� 5�        � ��$ 27(�6)   �� 5�        � ��$ Microsoft YaHei Light)�6+    5�   
   P� 5�      	 �@J�IsMouseOver
 . . �5�      ��   � ��8  6/   �� 5�        � ��8  60   5�      P� 5�      	 � ��
 . . �5�      ��   � ��8  6/   �� 5�        � ��8  60   5�      5�      5�      