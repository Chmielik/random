   M S B A M L   `   `   `  ����   WpfApplication2     WpfApplication2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
MainWindow��$	��492��$	��694��.���  � ColumnDefinitions �� $	��19* ��� $
��498* �.+��� $
��Left=�$��23��$��	60,30,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��172��$��1�� �� 
IsReadOnly ��  �� Path$ 
IsReadonly��� -   $��Rozpocznij losowanie��$��186,75,241,0q�$	��Top=�$��23�� J� RenderTransformOrigin$ 0.256,0.762&�$��1������ $ StartRandCommand��� $
��Left=�$��23��$��
330,30,0,0q�$
 Wrap=�$	��Top=�$	��170��$��1������ $ 	NumbersTo� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� $ 
IsReadonly��� $��120,140,161,0q�$
��Wrap=�$	��Top=�$��65��$��26(�$��1��$��Expanded&� �� TextAlignment$ Center=��� 	 � Language$	 pl-pl�$�Wylosowana liczba���� $��Losuj��$
��Left=�$��260,245,0,0q�$	��Top=�$��75��$��1������ $ RandCommand��� $��Button��$
��Left=�$��
10,431,0,0q�$	��Top=�$��75��$��2���� $��1��$
��Left=�$��	60,10,0,0q�$
��Wrap=�$	��Top=��� $	 pl-pl�$�Ilość zdających���� $��1��$
��Left=�$��
340,10,0,0q�$
��Wrap=�$	��Top=��� $	 pl-pl�$�Zakres losowanie���� $��1��$
��Left=�$��270,192,0,0q�$
��Wrap=�$	��Top=����� $ ActualResult�$ TwoWay=�$ PropertyChanged=�