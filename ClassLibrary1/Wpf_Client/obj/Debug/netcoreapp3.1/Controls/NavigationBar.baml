   M S B A M L   `   `   `  ����E  AWpf_Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Wpf_Client.ControlsWpf_Client.Controls  5      =#clr-namespace:Wpf_Client.ViewModelsWpf_Client.ViewModels  5      K*clr-namespace:Wpf_Client.States.NavigationWpf_Client.States.Navigation  5      =#clr-namespace:Wpf_Client.ConvertersWpf_Client.Converters  5	      '    !Wpf_Client.Controls.NavigationBar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Wpf_Client.Controls     5      2vm#clr-namespace:Wpf_Client.ViewModels     5      A
navigation*clr-namespace:Wpf_Client.States.Navigation     5      9	converter#clr-namespace:Wpf_Client.Converters     5	        � 	Resources  5      :   4Wpf_Client.Converters.EqualValueToParameterConverter   
EqualValue��%   &	          5   
   64   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    �� Padding$ 10q�6!   $��28(�6/   
�������$��SimpleTrader��6P     BrushPrimary1#��[ 6d   6�   � 5   
   $��1��6    �� EdgeMode$ Unspecified=�6     BrushPrimary2#��[ 6A     5       �� 
TargetType  	NavButton �� BasedOn��%0   '	�       7  �� 5      " 	�6   8   61   5       � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5       	� $��0��6   $
��Home��6*   +   %Wpf_Client.States.Navigation.ViewType   Home#��Z 5$       d� 	IsChecked 5    9   �� *CurrentViewModel+	 �� Mode$	 OneWay=�
 �� 	Converter#
 [   �� ConverterParameter)   #Wpf_Client.ViewModels.HomeViewModel"  ��5#      �� *UpdateCurrentViewModelCommand+5$      	� 5%      $��1��6   $
��Home��6*      	Portfolio#��Z 5)       5%   9   �� *CurrentViewModel+$	 OneWay=�#
 [  .   (Wpf_Client.ViewModels.PortfolioViewModel"  ��5(      �� *UpdateCurrentViewModelCommand+5)      	� 5*      $��2��6   $
��Home��6*   
   Buy#��Z 5.       5*   9   �� *CurrentViewModel+$	 OneWay=�#
 [  (  "Wpf_Client.ViewModels.BuyViewModel"  ��5-      �� *UpdateCurrentViewModelCommand+5.      	� 5/      $��3��6   $
��Sell��6*   50      51      52      