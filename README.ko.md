# Anatomy Analyzer [![English](https://img.shields.io/badge/Language-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/Language-中文-green.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/Language-한국어-red.svg)](README.ko.md)

동적 어셈블리 로딩 및 UI 분석을 위한 고급 WPF 애플리케이션으로, 강력한 리플렉션 기능과 고급 WPF 기술을 선보입니다.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/anatomyanalyzer.svg)](https://github.com/jamesnet214/anatomyanalyzer/stargazers)
[![Issues](https://img.shields.io/github/issues/jamesnet214/anatomyanalyzer.svg)](https://github.com/jamesnet214/anatomyanalyzer/issues)

## 프로젝트 개요

Anatomy Analyzer는 .NET 8.0 기반으로 구축된 고급 WPF 애플리케이션으로, 리플렉션을 통한 동적 어셈블리 로딩에 중점을 둡니다. 선택된 DLL 내의 UI 클래스에 대한 종합적인 뷰를 제공하며, TreeView를 사용하여 ControlTemplate과 계층 구조를 시각화합니다. 이 도구는 계층 구조의 모든 수준에서 UI 컴포넌트의 실시간 시각적 표현을 제공합니다.

<img src="https://github.com/user-attachments/assets/e369428c-6c19-4b1b-b008-d8d5a8daba74" width="49%"/>
<img src="https://github.com/user-attachments/assets/dd880126-0749-4f99-9548-15e561bfaa51" width="49%"/>
<img src="https://github.com/user-attachments/assets/b25ca7f8-77d5-483b-862f-1dc35494ab60" width="49%"/>
<img src="https://github.com/user-attachments/assets/e85f534b-0736-454d-bb20-7e12f5c07e12" width="49%"/>

## 주요 기능 및 기술적 구현

#### 1. 동적 어셈블리 로딩
- [x] .NET 리플렉션을 활용하여 DLL 어셈블리를 동적으로 로드
- [x] 로드된 어셈블리에서 UI 클래스 목록 추출 및 표시
#### 2. 고급 UI 분석
- [x] TreeView를 사용하여 ControlTemplate 구조 시각화
- [x] 선택한 컴포넌트에 대한 UI 계층 구조의 실시간 렌더링
#### 3. MVVM 아키텍처
- [x] Prism.Unity와 CommunityToolkit.Mvvm을 사용하여 MVVM 패턴 구현
- [x] ViewModel 기반 로직 관리를 통한 관심사 분리
#### 4. 모듈식 설계
- [x] 유지 보수성 향상을 위한 프로젝트 분배 및 모듈화
- [x] 구성 요소 간의 느슨한 결합을 위한 종속성 주입
#### 5. 고급 WPF 기술
- [x] 높은 수준의 WPF 기술을 보여주는 사용자 정의 컨트롤 개발
- [x] TreeView와 TreeViewItem을 위한 재귀적 ItemsControl 구현
- [x] 동적 바인딩을 통한 동적 테마 및 지역화
## 심층 기술 분석
- **리플렉션과 동적 로딩**: 런타임 시 어셈블리 분석을 위한 .NET 리플렉션의 고급 사용 사례 제시
- **MVVM 구현**: DI를 위한 Prism.Unity와 상용구 코드 감소를 위한 CommunityToolkit.Mvvm을 사용한 MVVM의 실제 적용 시연
- **UI 가상화**: 고급 ItemsPresenter 기술을 사용하여 복잡한 UI 계층 구조를 효율적으로 렌더링
- **사용자 정의 컨트롤 개발**: 특별한 시각화 요구 사항을 충족하는 전문적인 WPF 컨트롤 생성
- **모듈식 아키텍처**: 유지 보수 가능하고 확장 가능한 WPF 애플리케이션 생성의 모범 사례 제시

## 기술 스택
- WPF (Windows Presentation Foundation)
- .NET 8.0
- C# 10.0
- XAML
- Jamesnet.Wpf Framework
- Prism.Unity  
- CommunityToolkit.Mvvm
## 시작하기
### 필수 조건
- Visual Studio 2022 이상
- .NET 8.0 SDK
### 설치 및 실행
#### 1. 저장소 복제:
```
git clone https://github.com/jamesnet214/anatomyanalyzer.git
```
#### 2. 선호하는 IDE에서 솔루션 열기:
- Visual Studio
- Visual Studio Code  
- JetBrains Rider

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

#### 3. 빌드 및 실행
- 시작 프로젝트로 설정
- F5 키를 누르거나 실행 버튼을 클릭
- 최적의 경험을 위해 Windows 11 권장
## 기여
Anatomy Analyzer에 대한 기여를 환영합니다! 이슈를 제출하거나, Pull Request를 생성하거나, 개선 사항을 제안해 주세요.
## 라이선스
이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.
## 연락처
- 웹사이트: https://jamesnet.dev
- 이메일: jamesnet@jamesnet.dev, vickyqu115@hotmail.com

Anatomy Analyzer와 함께 고급 WPF 개발, 리플렉션 기술, MVVM 아키텍처의 세계로 뛰어들어 보세요. 이 프로젝트는 UI 분석을 위한 강력한 도구일 뿐만 아니라, 복잡한 WPF 개념, 의존성 주입, 프로젝트 모듈화, 고급 WPF 컨트롤 및 패턴 구현을 마스터하기 위한 교육 자료로도 활용될 수 있습니다.
