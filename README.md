# Game-Data-Structure (更新中) / [English](https://github.com/shajieChen/Game-Data-Structure/blob/master/English_V_GDS.md)
 大学很快过去了，一直觉得自己的学校就是一个巨大的坑钱项目</br>
 作为一个软件工程的学生居然把所有的主流语言都学过了，自己出来社会和社会上磨砺的竞争力差了很多</br>
 可是我是一个尽自己努力想做到最好的人，所以课程上面都想拿HD，导致自己在喜欢的游戏开发上面没投入很多时间（苦笑）</br>
 当然 作为学校RMIT的软件工程学生，终于在要毕业的这几年内看透了，</br>
 语言只是个实现工具，解决需求问题的关键在于对问题的抽象化，所以软件工程 就是门管理学嘛（苦笑）</br>
 开这篇的原因 是想提醒自己，不忘初心 好好加油。游戏中基本架构（下层决定上层）的解决思路以及自己想法 </br>
## Overview  
- [时间管理器](#时间管理器)
- [事件管理器](#事件管理器)
- [资产管理器](#资产管理器)
- [文件管理器](#文件管理器)
- [对象管理器](#对象管理器)  
- [Log](#Log)  

![OverView-Diagram](https://github.com/shajieChen/Game-Data-Structure/blob/master/ClassGraph/BaseSystem.png) 
## 时间管理器
### Timer计时器的实现[Todo 列表]
- [x] 支持回调函数 -- (10/10/2019)
- [x] 应用于LateUpdate，处理完所有逻辑问题之后 -- (10/10/2019)
- [x] 增删遍历 -- (10/10/2019)
思路图：</br>
>#### 简单来说，这个是以帧为驱动，Timer所处的特定帧(用Timer.Duration推算出)区域范围，TimeList进行遍历。

>>![思路图](https://github.com/shajieChen/Game-Data-Structure/blob/master/ClassGraph/timerList_结构图.png) 

>解决方案图： </br>
>>![解决方案图](https://github.com/shajieChen/Game-Data-Structure/blob/master/ClassGraph/TimerList_解析.png) 

>>![解决方案图](https://github.com/shajieChen/Game-Data-Structure/blob/master/ClassGraph/Timer_解析.png) 

>伪代码： </br>
>>![伪代码](https://github.com/shajieChen/Game-Data-Structure/blob/master/ClassGraph/timer_伪代码.png) 
>自己遇到的问题： </br> 
>>1. 精度问题，一开始我的hashTable设定很小，这导致了之后要不断的查找UrgentTimer(麻烦且不可控)</br>
>>   解决方法，HashTable扩大到很大范围 但是要小于Int.MaxValue, 并且Int.MaxValue 用于判断不正确的timer</br> 
## 事件管理器
### 事件管理器的实现[Todo 列表]
思路图：</br>

解决方案图： </br>

伪代码： </br>

自己遇到的问题： </br>
## 资产管理器
### 资源管理器 -- 不做热更[Todo 列表]
思路图：</br>

解决方案图： </br>

伪代码： </br>

自己遇到的问题： </br>
## 文件管理器
### 文件管理器 -- 配置文件[Todo 列表]
- [ ] 通用配置文件(包括EditorUI编辑) 已经特殊配置文件编辑  
- [ ] 读取配置文件
- [ ] 配置文件与类对象属性对应
思路图：</br>

解决方案图： </br>

伪代码： </br>

自己遇到的问题： </br>
## 对象管理器
### 对象管理器 -- 优化为主[Todo 列表]

思路图：</br>

解决方案图： </br>

伪代码： </br>

自己遇到的问题： </br>
## Log
- 25/9/2019 目标是 基本框架，服务器，渲染通道 
- 25/9/2019 等完成了再公开
- 28/9/2019 分析游戏中频率高的需要使用到框架的东西


------
###### 作者 [@Evan-Shajie] 于25/9/2019 开始编辑
------