   M S B A M L   `   `   `  ����D  @GamesNews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GamesNews	GamesNews  5   	       GamesNews.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GamesNews     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
���   �.+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��gridList��5
      $
��Left=�6#   $	��378��6>   $��0,41,0,0q�6K   $	��Top=�6]   $	��792��6u   
�������   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Image��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 68      
IsReadOnly .    CellTemplate 5      �� 5      .R�5      �� ��6$   �� *ImageSources+5      5      5      �� 5   
   -   5        $��Загрузить��5      $
��Left=�6%   $��	60,10,0,0q�6@   $	��Top=�6S   $	��209��6k   6w   �� 5   
   -   5        $��Обновить��5      $
��Left=�6$   $��
517,10,0,0q�6?   $	��Top=�6S   $	��209��6k   6w   5      5      