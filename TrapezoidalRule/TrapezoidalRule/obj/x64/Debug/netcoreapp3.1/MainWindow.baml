   M S B A M L   `   `   `  ????J  FTrapezoidalRule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TrapezoidalRuleTrapezoidalRule  5   	        TrapezoidalRule.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:TrapezoidalRule     5   	     ? Title$  
MainWindow??5   	   $	??696??6   $
??1112??6)   .??5	      ? 
????ح? ? ColumnDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? -   5         ??Name$ 	MainPanel??5      $y?Visible=?6(   $??3??6=   .+?5      ?? $I??CEnter your quadratic equation's coefficients and integration range.??6   $
??Bold"?6c   $??40(?6u    ?? TextAlignment$ Center=?6?   ?? 5      $??0 25 0 0q?6   $??Coefficients??6*   $??30(?6>   $
??Bold"?6L   $ Center=?6^   ? 5      $??	0 30 0 0 q?6   $??150px??6&    5      ?? 5      $??* ?6'   ?? 5      $??* ?6'   ?? 5      $??* ?6'    ? RowDefinitions 5      ?? 5      $??* ?6$   ?? 5      $??* ?6$   .+?5       ?? $??a??6   $??0??6%   $??0??65   $??20(?6B   $ Center=?6P   $
??Bold"?6g   ?? 5!      $??b??6   $??1??6%   $??0??65   $??20(?6B   $ Center=?6P   $
??Bold"?6g   ?? 5"      $??c??6   $??2??6%   $??0??65   $??20(?6B   $ Center=?6P   $
??Bold"?6g   ?? 5$      $??0??6   $??1??6,   $ Center=?69   $??20(?6P   $??0 20 0 0q?6^   ?? 5%      -   5         ??Name$ aCoefficient??5%      $??30??64   $??30??6?    ?? 5&      $	?x^2??6   $
??Bold"?6%   5'      ?? 5)      $??1??6   $??1??6,   $ Center=?69   $??20(?6P   $??0 20 0 0q?6^   ?? 5*      -   5        $ bCoefficient??5*      $??30??64   $??30??6?    ?? 5+      $?x??6   $
??Bold"?6#   5,      ?? 5.      $??2??6   $??1??6,   $ Center=?69   $??20(?6P   $??0 20 0 0q?6^   ?? 5/      -   5        $ cCoefficient??5/      $??30??64   $??30??6?   50      51      ?? 53      $??0 25 0 0q?6   $??Integration Range??6*   $??30(?6C   $
??Bold"?6Q   $ Center=?6c   ?? 55      $??30(?6   $
??Wrap=?6&   $ center=?6:   ?? 56      $?[??6    ?? 57      -   5        $ 
StartRange??57      $??40??6.   $??40??69    ?? 58      $?,??6    ?? 59      -   5        $ EndRange??59      $??40??6,   $??40??67    ?? 5:      $?]??6   5;      ?? 5=      $??Additional options:??6   $
??Bold"?63   $??40(?6E   $ Center=?6S   ?? 5?      $??0 25 0 0q?6   $*??$Choose DDL implementing integration.??6*   $??30(?6V   $
??Bold"?6d   $ Center=?6v   ? 5@      $??	0 30 0 0 q?6   $??150px??6&    5A      ?? 5B      $??* ?6'   ?? 5C      $??* ?6'   ?? 5D      $??* ?6'    5F      ?? 5G      $??* ?6$   ?? 5H      $??* ?6$   .+?5J      	? -   5         	?Name$ checkAsm??5J      $??	Assembler??60   $??15(?6D   $??1??6R   $??0??6b    	? 	GroupName$ Library??6o   $
??Bold"?6?    d? 	IsChecked$
 TrueY?6?   	 ? LayoutTransform	 5K      ?? 5L      
 ?? ScaleX$
 2Q?6)    ?? ScaleY$ 2Q?64   5N      	? 5P      -   5        $ checkCSharp??5P      $??C#??63   $??15(?6@   $??1??6N   $??1??6^   $ Library??6k   $
??Bold"?6   	 5Q      ?? 5R      $
 2Q?6)   $ 2Q?64   5T      5U      ?? 5V      $??0 25 0 0q?6   $M??GChoose number of threads that will be used during execution of program.??6*   $??30(?6y   $
??Bold"?6?   $ Center=?6?   ?? 5X      -	   5         ??Name$ ThreadSlider??5X      $??0,15,0,0q?5Y       ? Minimum$ 1Q?5Z       ? Maximum$	 100Q?5[       ?? TickPlacement$ BottomRight=?5\       ?? TickFrequency$ 1Q?5]      $	??252??5^      	 5_      ?? 5`      $
 2Q?6%   $ 2Q?60   5b      ?? 5d      $
??30.5??6   $??Right=?5e      $??16??5f       ?? TextAlignment$ Center=?5g      $??10(?5h      ??5i      ??  ?? ElementName$ ThreadSlider?? ?? Path$ Value? ?? UpdateSourceTrigger$ PropertyChanged=? ?? StringFormat$ N0??.??5k   /   5l      ?? 5n      -
   5        $??Calculate Integral??5n      $
??Bold"?5o      
????p??$??0,20,0,0q?5q      $	??120??5r      $??5q?5s      5t      5u      ?? 5w   
   -   5        $ Results??5w      $y?Hidden=?6&   $??3??6:   .+?5x      ?? $??Result of integration:??6   $??30(?66   $ Center=?6D   $
??Bold"?6[   ?? 5y      -   5         ??Name$ IntegralResult??5y      $?? ??60   $??30(?68   $ Center=?6F   $
??Bold"?6]   ?? 5z      $??Time of Execution:??6   $??30(?63   $ Center=?6A   $
??Bold"?6X   ?? 5{      -   5        $ ExecutionTime??5{      $?? ??6/   $??30(?67   $ Center=?6E   $
??Bold"?6\   ?? 5|      $??Chosen DDL:??6   $??30(?6+   $ Center=?69   $
??Bold"?6P   ?? 5}      -   5        $ 	ChosenDDL??5}      $?? ??6+   $??30(?63   $ Center=?6A   $
??Bold"?6X   ?? 5~      -   5        $??Return??5~      $
??Bold"?5      
????p??$??0,20,0,0q?5?      $	??150??5?      $??40??5?      $??5q?5?      5?      5?      ?? 5?   
   -   5        $ BadInput??5?      $y?Hidden=?6'   $??1??6;   .+?5?      ?? $??	Bad input??6   $??30(?6)   $ Center=?67   $
??Bold"?6N   
???  ??6`   ?? 5?      -   5        $??Return??5?      $
??Bold"?5?      
????p??$??0,20,0,0q?5?      $	??150??5?      $??40??5?      $??5q?5?      5?      5?      5?      5?      