# Anatomy Analyzer 解剖分析器 [![English](https://img.shields.io/badge/Language-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/Language-中文-green.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/Language-한국어-red.svg)](README.ko.md)

一个先进的WPF应用程序，用于动态程序集加载和UI分析，展示了强大的反射功能和高级WPF技术。

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/anatomyanalyzer.svg)](https://github.com/jamesnet214/anatomyanalyzer/stargazers)
[![Issues](https://img.shields.io/github/issues/jamesnet214/anatomyanalyzer.svg)](https://github.com/jamesnet214/anatomyanalyzer/issues)

## 项目概览

Anatomy Analyzer 是一个基于.NET 8.0构建的高级WPF应用程序，专注于通过反射进行动态程序集加载。它提供了所选DLL中UI类的全面视图，使用TreeView可视化其ControlTemplates和层次结构。该工具提供了层次结构每个级别的UI组件的实时视觉表示。

<img src="https://github.com/user-attachments/assets/e369428c-6c19-4b1b-b008-d8d5a8daba74" width="49%"/>
<img src="https://github.com/user-attachments/assets/dd880126-0749-4f99-9548-15e561bfaa51" width="49%"/>
<img src="https://github.com/user-attachments/assets/b25ca7f8-77d5-483b-862f-1dc35494ab60" width="49%"/>
<img src="https://github.com/user-attachments/assets/e85f534b-0736-454d-bb20-7e12f5c07e12" width="49%"/>

## 主要特性和技术实现

#### 1. 动态程序集加载
- [x] 利用.NET反射动态加载DLL程序集
- [x] 从加载的程序集中提取和显示UI类列表

#### 2. 高级UI分析
- [x] 使用TreeView可视化ControlTemplate结构
- [x] 实时渲染所选组件的UI层次结构

#### 3. MVVM架构
- [x] 使用Prism.Unity和CommunityToolkit.Mvvm实现MVVM模式
- [x] 通过基于ViewModel的逻辑管理实现关注点分离

#### 4. 模块化设计
- [x] 项目分布和模块化，提高可维护性
- [x] 依赖注入实现组件间的松耦合

#### 5. 高级WPF技术
- [x] 自定义控件开发，展示高级WPF技能
- [x] 为TreeView和TreeViewItem实现递归ItemsControl
- [x] 通过动态绑定实现动态主题和本地化

## 深入技术分析

- **反射和动态加载**：展示了.NET反射在运行时分析程序集的高级用法
- **MVVM实现**：演示了使用Prism.Unity进行DI和CommunityToolkit.Mvvm减少样板代码的MVVM实际应用
- **UI虚拟化**：使用高级ItemsPresenter技术高效渲染复杂的UI层次结构
- **自定义控件开发**：为独特的可视化需求创建专门的WPF控件
- **模块化架构**：说明了创建可维护和可扩展的WPF应用程序的最佳实践

## 技术栈

- WPF (Windows Presentation Foundation)
- .NET 8.0
- C# 10.0
- XAML
- Jamesnet.Wpf Framework
- Prism.Unity
- CommunityToolkit.Mvvm

## 开始使用

### 先决条件

- Visual Studio 2022 或更高版本
- .NET 8.0 SDK

### 安装和执行

#### 1. 克隆仓库：

```
git clone https://github.com/jamesnet214/anatomyanalyzer.git
```

#### 2. 在您喜欢的IDE中打开解决方案：
- Visual Studio
- Visual Studio Code
- JetBrains Rider

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

#### 3. 构建和运行
- 设置为启动项目
- 按F5或点击运行按钮
- 推荐使用Windows 11以获得最佳体验

## 贡献

欢迎对Anatomy Analyzer做出贡献！请随时提交问题、创建拉取请求或提出改进建议。

## 许可证

本项目采用MIT许可证分发。有关更多详细信息，请参阅[LICENSE](LICENSE)文件。

## 联系方式

- 网站：https://jamesnet.dev
- 电子邮件：jamesnet@jamesnet.dev, vickyqu115@hotmail.com

通过Anatomy Analyzer深入探索高级WPF开发、反射技术和MVVM架构的世界。这个项目不仅是一个强大的UI分析工具，还是一个教育资源，用于掌握复杂的WPF概念、依赖注入、项目模块化以及高级WPF控件和模式的实现。
