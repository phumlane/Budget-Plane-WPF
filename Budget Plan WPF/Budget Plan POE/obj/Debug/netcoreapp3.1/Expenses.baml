   M S B A M L   `   `   `  ����J  FBudget Plan POE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Budget_Plan_POEBudget_Plan_POE  5   	       Budget_Plan_POE.Expenses   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Budget_Plan_POE     5   	     � Title$  Expenses��5   	   $	��500��6   $	��600��6'   ���	#FFBDA9A9.��5	      � $��0,0,0,-6q�6   .+�5
   
   �� -   5         ��Name$ label��5
      $��Budget Plan��6   $
��Left=�65   $��
250,15,0,0q�6P   $	��Top=�6d    J� RenderTransformOrigin$ 1.364,0.324&�6|   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $ label1��5      $��Monthly Income��6    $
��Left=�69   $��
10,100,0,0q�6T   $	��Top=�6h   �� 5   
   -   5        $ label2��5      $	��Tax��6    $
��Left=�6.   $��
10,140,0,0q�6I   $	��Top=�6]   �� 5   
   -   5         ��Name$ 	txtIncome��5      $
��Left=�6%   $��23��6@   $��130,100,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��180��6�   $ 0.484,-0.027&�6�   �� 5   
   -   5        $ txtTax��5      $
��Left=�6"   $��23��6=   $��130,140,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��180��6�   �� 5   
   -   5         ��Name$ 	btnSubmit��5      $
��Next��6$   $��Center=�63   $
��Bold"�6P   ���	#FFB29074$��
10,390,0,0q�6y   $��Center=�6�   $��75��6�   $ 0.453,0.276&�6�   �� 5   
   -   5        $ 
txtGrocery��5      $
��Left=�6&   $��130,180,0,0q�6A   $��23��6V   $
 Wrap=�6b   $	��Top=�6v   $	��180��6�   �� 5   
   -   5        $ txtWaterAndLight��5      $
��Left=�6,   $��130,220,0,0q�6G   $��23��6\   $
 Wrap=�6h   $	��Top=�6|   $	��180��6�   �� 5   
   -	   5        $ 	txtTravel��5      $
��Left=�6%   $��130,260,0,0q�6@   $��23��6U   $
 Wrap=�6a   $	��Top=�6u   $	��180��6�   �� 5   
   -
   5        $ txtPhone��5      $
��Left=�6$   $��130,300,0,0q�6?   $��23��6T   $
 Wrap=�6`   $	��Top=�6t   $	��180��6�   �� 5   
   -   5        $ txtOther��5      $
��Left=�6$   $��130,340,0,0q�6?   $��23��6T   $
 Wrap=�6`   $	��Top=�6t   $	��180��6�   �� 5   
   -   5        $ label3��5      $��Grocery��6    $
��Left=�62   $��
10,180,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ label4��5      $��Water and Light��6    $
��Left=�6:   $��
10,220,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ label5��5      $��Travel Cost��6    $
��Left=�66   $��
10,260,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ label6��5      $��Phones Cost��6    $
��Left=�66   $��
10,300,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ label7��5      $��Others Expenses��6    $
��Left=�6:   $��
10,340,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ label8��5      $+��%Can you enter the following Expenses:��6    $
��Left=�6P   $��	10,62,0,0q�6k   $	��Top=�6~   $
��Bold"�6�   �� 5   
   -   5        $ label9��5      $��Monthly Expenditures��6    $
��Left=�6?   $��	10,35,0,0q�6Z   $��Black"�6m   $	��Top=�6�   $��18(�6�   5      5      