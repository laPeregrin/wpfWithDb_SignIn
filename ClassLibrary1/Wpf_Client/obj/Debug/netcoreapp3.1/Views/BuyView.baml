   M S B A M L   `   `   `  ����E  AWpf_Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Wpf_Client.ViewsWpf_Client.Views  5          Wpf_Client.Views.BuyView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Wpf_Client.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��Center=�6   $��0��61   .+�5      �� $	��100��6   $��0 0 10 0q�6"   ��64   �� *Symbol+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��Search��6   ��6&   �� *SearchSymbolCommand+5      � 5   
   $��1��6   $��Center=�6!   $��Center=�6>   .+�5      �� 
���   �$��1q�6)    �� Padding$ 20q�6=   ._�5      �� .+�5      �� $��Center=�6    $��45��6=   $��32(�6H   ��6V   �� *Symbol+�� 5      $��0 10 0 0q�6    ��62   �� *
StockPrice+ �� StringFormat$ {0:C}��5      5      �� 5      
���   �$��1q�6)   $ 20q�6=   ._�5      �� .+�5      � $
��0 10q�6    .+�5      �� $	��121��6$   $��Shares to buy:��60   $��0 0 10 0q�6F   �� 5      $��50��6"   ��6/   �� *SharesToBuy+$ PropertyChanged=�5       � 5!      $
��0 10q�6!   .+�5"      �� $��Price per share:��6$   �� 5#      ��6$   �� *
StockPrice+$ {0:C}��5$      �� 5%      $	��100��6    $��Center=�6,   $��32(�6I   ��6W   �� *
TotalPrice+$ {0:C}���� 5&      $
��0 10q�6   $	��Buy��6-   ��6;   �� *BuyStockCommand+5'      5(      5)      5*      5+      