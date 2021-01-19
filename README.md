# Csharp爬取音乐源码

#### 介绍
基于.NET的音乐搜索与播放软件（编程语言：C#，爬取4个平台：酷我/网易云/酷狗/QQ）


#### 基本思路
1、模拟搜索：通过关键字，获取歌曲列表<br />
2、获取歌曲关键信息（歌曲ID之类的唯一标识）<br />
3、根据歌曲ID，通过指定方法（一个接口），获取歌曲播放地址（一个url）<br />
4、将歌曲下载到本地，实现下载或播放<br />
限制：<br />
1、vip音乐大多没法爬取（酷我除外），而且为试听品质<br />
2、缺少多线程编程，试听时会整个程序卡住<br />
3、代码内容相对较少，代码编写规范，个人认为是很好的入门project


#### 安装教程
使用VS2013可直接打开，无数据库连接<br />
有自定义配置文件（txt文本，在 \bin\Debug\config.txt ）



#### 分支说明
master 为主分支，目前为最原始版本<br />
master-dev 为开发版本，个人已经不再维护本分支，欢迎有能力的网友接手<br />
master-origin 为最原始版本，代码结构相对简单，保留<br />



#### 捐助
如果这个项目对您有所帮助，请扫下方二维码打赏一杯咖啡。
![输入图片说明](https://images.gitee.com/uploads/images/2020/1005/195155_1a739694_5684918.png "芦荟柚子茶.png")
