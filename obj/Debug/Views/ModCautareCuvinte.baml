   M S B A M L   `   `   `  ����D  @Dictionar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Dictionar.ViewsDictionar.Views  5      '    !Dictionar.Views.ModCautareCuvinte   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      )localclr-namespace:Dictionar.Views  5      6ie1(http://schemas.microsoft.com/xps/2005/06    6:   .��5
      � $��0,0,0,20q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$
 cBox��5      $��259,0,0,0.4q�6�   ��6!   ��  �� Path$ categorieProprietate� �� SelectedValue 6S   �� *CategorieSelectata+5      �� 5   
   $��Cautati cuvinte :��6   $��Right=�6-   $��Bottom=�5      $	��148��6/   $��21��6;   $��0,0,343,336.6q�6G   $��1��6^   �� 5   
   -   5         ��Name$ txtAuto��5   @   $��Right=�5      $��Bottom=�6.   $��25��5      $	��325��6   $��0,0,38,336.6q�6*    �� TextWrapping$ NoWrap=�6Q   $��1��6g   ��6t   �� *	TextScris+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ lbSuggestion��5      
�������$��1��5   &   $y�Visible=�63   $��Right=�5      $	��Top=�6.   $	��325��6F   $��0,28.6,38,0q�6R   ��5   (   �� $ ListaCuvinteScrise� �� SelectedItem 6X   �� *
CuvantAles+	 �� Mode$	 TwoWay=���5      �� 5      .R�5      �� 
 �� Orientation$
 
Horizontal=�6!   .+�5      �� ��6$   �� $
 Nume�6A   5      5      5!      �� 5"   
   $��437,75.6,22,89.6q�6;   $��1��6U   ��6   �� $ CuvantAles.Imagine�6U   �� 5#   
   -   5        $��Id��5#   [   $��1��6   $��31��6   $
��Left=�6)   $��120,124.6,0,0q�6D   $	��Top=�6e   $	��234��6}   ��6�   �� $ CuvantAles.Id�$	 TwoWay=��� 5$   
   -   5        $
��Nume��5$   [   $��1��6   $��31��6   $
��Left=�6)   $��120,162.6,0,0q�6D   $	��Top=�6g   $	��234��6   ��6�   �� $ CuvantAles.Nume�$	 TwoWay=��� 5%   
   -   5        $��	Descriere��5%   [   $��1��6   $��31��6   $
��Left=�6)   $��120,200.6,0,0q�6D   $	��Top=�6l   $	��234��6�   ��6�   �� $ CuvantAles.Descriere�$	 TwoWay=��� 5&   
   -   5        $��label1��5&   _   $��Id��6   $��1��6   $
��Left=�6*   $��30,131.6,0,112.6q�6E   $��27��6m   �� 5'   
   -   5        $��label2��5'   n   $��	Descriere��6   $��1��6$   $��37��61   $
��Left=�6=   $��30,196.6,0,0q�6X   $	��Top=�6|   $��78��6�   �� 5(   
   -	   5        $��label3��5(   i   $
��Nume��6   $��1��6   $��38��6,   $
��Left=�68   $��30,162.6,0,0q�6S   $	��Top=�6w   $��55��6�   �� 5)   
   -
   5         ��Name$ 	Categorie��5)   [   $��1��6   $��35��6   $
��Left=�6)   $��120,238.6,0,0q�6D   $	��Top=�6n   $	��234��6�   ��6�   �� $ CuvantAles.Categorie�$	 TwoWay=��� 5*   
   -   5        $ label2_Copy1��5*   n   $��	Categorie��6   $��1��6$   $��28��61   $
��Left=�6=   $��30,238.6,0,0q�6X   $	��Top=�6�   �� 5+   
   $��Alegeti categoria��6   $
��Left=�6,   $��
120,-3,0,0q�6G   $	��Top=�6[   $	��128��6s   5-      5.      