# SimpleSpriteSheetPivotEditor - 精灵轴心点批量编辑器

[![[附件/readme_file/2d874dda9ea9e96683e9483fa81c08f7_MD5.svg]]](https://unity3d.com/get-unity/download)
[![[附件/readme_file/0d356e72fcfaae41be0d7adf6fad1c69_MD5.svg]]](https://opensource.org/licenses/MIT)
[![[附件/readme_file/35a3f2b74a952086d26f6b05d52b24d5_MD5.svg]]](https://github.com/yourusername/SimpleSpriteSheetPivotEditor/releases)

## 📖 简介

SimpleSpriteSheetPivotEditor是一个Unity编辑器扩展工具，专门用于解决精灵表(Sprite Sheet)中批量设置所有精灵轴心点(Pivot)的问题。这个工具可以帮助您快速统一设置多个精灵的轴心点，极大提高工作效率。

![[附件/readme_file/Pasted image 20250617090604.jpeg]]

## ✨ 特点

- 🚀 **批量处理**: 一键设置同一精灵表中所有精灵的轴心点
- 🎯 **精确控制**: 使用滑动条精确调整X和Y轴心点值
- 🔧 **智能设置**: 自动设置为Custom模式，确保自定义轴心点生效
- 💬 **友好提示**: 提供详细的操作反馈和错误处理
- 🎨 **简洁界面**: 直观易用的用户界面
- ⚡ **高效率**: 避免手动逐个修改的繁琐过程

## 📦 安装方法

### 方法1: Unity Package Manager (推荐)
1. 打开Unity编辑器
2. 打开 `Window > Package Manager`
3. 点击左上角的 `+` 按钮
4. 选择 `Add package from git URL`
5. 输入: `https://github.com/yourusername/SimpleSpriteSheetPivotEditor.git`

### 方法2: 下载UnityPackage
1. 前往 [Releases页面](https://github.com/yourusername/SimpleSpriteSheetPivotEditor/releases)
2. 下载最新版本的 `.unitypackage` 文件
3. 在Unity中双击导入

### 方法3: 手动安装
1. 下载本仓库的源码
2. 将 `SimpleSpriteSheetPivotEditor.cs` 放入项目的 `Assets/Editor/` 文件夹中
3. 等待Unity编译完成

## 🚀 使用方法

1. **打开工具窗口**
   - 在Unity菜单栏中点击 `Tools > Simple Sprite Pivot Editor`

2. **选择目标精灵表**
   - 将精灵表拖拽到"目标精灵表"字段中

3. **调整轴心点**
   - 使用滑动条调整X和Y轴心点值（范围0-1）
   - X=0, Y=0 表示左下角
   - X=1, Y=1 表示右上角
   - X=0.5, Y=0.5 表示中心点

4. **应用设置**
   - 点击"设置轴心点"按钮
   - 完成后会显示成功提示


## ⚠️ 注意事项

- 目标精灵表必须设置为 **Multiple** 模式
- 修改会影响精灵表中的 **所有精灵**
- 操作会自动保存并重新导入资源
- 建议在修改前备份重要项目

## 🔧 故障排除

| 问题 | 解决方法 |
|------|----------|
| 工具不出现在菜单中 | 确认脚本已放入Editor文件夹，检查控制台错误 |
| 设置后轴心点未改变 | 确认精灵表为Multiple模式，检查是否点击Apply |
| 出现错误提示 | 按照错误信息修复，确保选择有效的精灵表资源 |

## 🛠️ 系统要求

- Unity 2019.4 LTS 或更高版本
- 支持 Windows、macOS、Linux

## 🤝 贡献

欢迎提交Issue和Pull Request来改进这个工具！

### 开发指南
1. Fork 本仓库
2. 创建特性分支 (`git checkout -b feature/AmazingFeature`)
3. 提交更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 打开 Pull Request

## 📄 许可证

本项目采用 [MIT License](LICENSE) 开源协议。

---

⭐ 如果这个工具对你有帮助，请给个Star支持一下！