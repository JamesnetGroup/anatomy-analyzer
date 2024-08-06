# Anatomy Analyzer [![English](https://img.shields.io/badge/Language-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/Language-中文-green.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/Language-한국어-red.svg)](README.ko.md)

An advanced WPF application for dynamic assembly loading and UI analysis, showcasing powerful reflection capabilities and advanced WPF techniques.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/anatomyanalyzer.svg)](https://github.com/jamesnet214/anatomyanalyzer/stargazers)
[![Issues](https://img.shields.io/github/issues/jamesnet214/anatomyanalyzer.svg)](https://github.com/jamesnet214/anatomyanalyzer/issues)

## Project Overview

Anatomy Analyzer is an advanced WPF application built on .NET 8.0, focusing on dynamic assembly loading through reflection. It provides a comprehensive view of UI classes within selected DLLs, visualizing their ControlTemplates and hierarchical structures using a TreeView. This tool offers real-time, visual representation of UI components at every level of the hierarchy.

<img src="https://github.com/user-attachments/assets/e369428c-6c19-4b1b-b008-d8d5a8daba74" width="49%"/>
<img src="https://github.com/user-attachments/assets/dd880126-0749-4f99-9548-15e561bfaa51" width="49%"/>
<img src="https://github.com/user-attachments/assets/b25ca7f8-77d5-483b-862f-1dc35494ab60" width="49%"/>
<img src="https://github.com/user-attachments/assets/e85f534b-0736-454d-bb20-7e12f5c07e12" width="49%"/>

## Key Features and Technical Implementation

#### 1. Dynamic Assembly Loading
- [x] Utilization of .NET reflection to dynamically load DLL assemblies
- [x] Extraction and display of UI class lists from loaded assemblies

#### 2. Advanced UI Analysis
- [x] Visualization of ControlTemplate structures using TreeView
- [x] Real-time rendering of UI hierarchies for selected components

#### 3. MVVM Architecture
- [x] Implementation of MVVM pattern using Prism.Unity and CommunityToolkit.Mvvm
- [x] Separation of concerns with ViewModel-based logic management

#### 4. Modular Design
- [x] Project distribution and modularization for improved maintainability
- [x] Dependency Injection for loose coupling between components

#### 5. Advanced WPF Techniques
- [x] Custom Control development showcasing high-level WPF skills
- [x] Implementation of recursive ItemsControl for TreeView and TreeViewItem
- [x] Dynamic theming and localization through dynamic binding

## In-Depth Technical Analysis

- **Reflection and Dynamic Loading**: Showcases advanced use of .NET reflection for runtime analysis of assemblies
- **MVVM Implementation**: Demonstrates practical application of MVVM using Prism.Unity for DI and CommunityToolkit.Mvvm for boilerplate reduction
- **UI Virtualization**: Efficient rendering of complex UI hierarchies using advanced ItemsPresenter techniques
- **Custom Control Development**: Creation of specialized WPF controls for unique visualization needs
- **Modular Architecture**: Illustrates best practices in creating maintainable and scalable WPF applications

## Tech Stack

- WPF (Windows Presentation Foundation)
- .NET 8.0
- C# 10.0
- XAML
- Jamesnet.Wpf Framework
- Prism.Unity
- CommunityToolkit.Mvvm

## Getting Started

### Prerequisites

- Visual Studio 2022 or later
- .NET 8.0 SDK

### Installation and Execution

#### 1. Clone the repository:

```
git clone https://github.com/jamesnet214/anatomyanalyzer.git
```

#### 2. Open the solution in your preferred IDE:
- Visual Studio
- Visual Studio Code
- JetBrains Rider

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

#### 3. Build and Run
- Set as startup project
- Press F5 or click the run button
- Windows 11 recommended for optimal experience

## Contributing

Contributions to Anatomy Analyzer are welcome! Please feel free to submit issues, create pull requests, or suggest improvements.

## License

This project is distributed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Contact

- Website: https://jamesnet.dev
- Email: jamesnet@jamesnet.dev, vickyqu115@hotmail.com

Dive into the world of advanced WPF development, reflection techniques, and MVVM architecture with Anatomy Analyzer. This project not only serves as a powerful tool for UI analysis but also as an educational resource for mastering complex WPF concepts, dependency injection, project modularization, and the implementation of high-level WPF controls and patterns.
