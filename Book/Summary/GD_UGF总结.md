### 游戏入口:GameEntry(又分别有三个局部类)

```c#
-:GameEntry.Builtin
	用来初始化框架的基础组件
    
-:GameEntry.Extension
	用来初始化框架的扩展内容的组件
    
-:GameEntry.Game
    用来初始化自定义的游戏内容组件
    
    如要添加新的初始内容组件,可以额外添加一个GameEntry的局部类,并实现起逻辑,并且在GameEntry主类中进行初始化
```

流程:![Procedure](D:\Project\UnityProject\GDFramework\Book\Summary\PNG\Procedure.png)
