   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MVVMMVVM  5   	       MVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:MVVM     5   	     � Title$  
MainWindow��5   	   $	��450��6   $��329.6��6)   .��5	      � .+�5
   
   �� $��Сторона A��6   $
��Left=�6$   $��
104,40,0,0q�6?   $	��Top=�6S   �� 5   
   $��Сторона B��6   $
��Left=�6$   $��104,100,0,0q�6?   $	��Top=�6T   �� 5   
   $��Висота h��6   $
��Left=�6#   $��104,161,0,0q�6>   $	��Top=�6S    J� RenderTransformOrigin$ -0.168,0.504&�6k   �� 5   
   $��Площа S��6   $
��Left=�6"   $��104,245,0,0q�6=   $	��Top=�6R   �� 5   
   $��Об'єм V��6   $
��Left=�6"   $��104,300,0,0q�6=   $	��Top=�6R   �� 5   
   -   5         ��Name$ side_a��5   �   $
��Left=�6   $��23��6-   $��
104,71,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��120��6y   ��6�   �� *	Number1+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   -   5        $ side_b��5   �   $
��Left=�6   $��23��6-   $��104,131,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   ��6�   �� *	Number2+$ PropertyChanged=��� 5   
   -   5        $ height��5   �   $
��Left=�6   $��23��6-   $��104,192,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   ��6�   �� *	Number3+$ PropertyChanged=��� 5   
   -   5        $ S��5   �   $
��Left=�6   $��23��6-   $��104,276,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z    �� 
IsReadOnly . ��6�   �� *	Number4+ �� Mode$ OneWay=�6�   �� 5   
   -   5        $ V��5   �   $
��Left=�6   $��23��6-   $��104,331,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z    . ��6�   �� *	Number5+$ OneWay=�6�   5      5      