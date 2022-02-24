Конструктор тренировок
===========
конструктор для создания тренировок на каждый день 
спринт проект 

Страницы
===========
В приложении имеются отличительные страницы от других приложений 

![f1](https://ia.wampi.ru/2022/02/23/IZOBRAZENIE_2022-02-23_031732.png)


![f1](https://ie.wampi.ru/2022/02/23/IZOBRAZENIE_2022-02-23_031759.png)



DATA BASE
===========
**sqllite**
| Workout | User | ListWorkout|
|----------------|---------|---------|
| IDWorkout | IDUser | iDWorkout |
| Name | Login | IDUser |
| Title | Password | iDWorkoutList |
| Path | Name | Count |
| Time | Path | Time |
| Count | BirthDay | |
|  | Gender | |
|  | Number |  |


Optimize project
===========
**FFImageLoading**
- Package Added `FFImageLoading`
- фоновая загрузка изображений с возможностью повторения запросов
- уменьшение прогрузки анимации 

UI
===========
**asset and figma(Comunity)**
- Использованны готовые ассеты для визуального представления проекта 
- Ресурсы предоставляют возможность включать в приложение произвольные файлы, текст, xml, шрифты
- Добавленные в проект, будут отображаться точно так же, как файловая система, которую приложение может считывать с помощью  `AssetManager`

- figma [тык](https://www.figma.com/file/tXmUIUypsoXkouMNFPbQq8/Untitled?node-id=0%3A1)

![f1](https://ie.wampi.ru/2022/02/19/IZOBRAZENIE_2022-02-19_224511.png)

Fonts
===========
**Montserrat** `embedded resource` `TrainingConstructor\founts` [тык](https://fonts-online.ru/fonts/montserrat) 
- Montserrat-Black.ttf
- Montserrat-BlackItalic.ttf
- Montserrat-Light.ttf
- Montserrat-Medium.ttf


Packages NuGet
===========
- Visual Material  **_xamarin.forms.visual.material_** 
- SQL-Lite **_sqlite-net-pcl_** 
- FFImageLoading
- FFImageLoading.Forms
- Xamarin.Forms.PancakeView
- Xamarin.Forms.DebugRainbows
- ThriveGmbH.BottomNavigationBar.XF **BottomBar**
- Syncfusion.Xamarin.SfComboBox **ComboBox**

BottomBar
===========
**навигационная панель находящаяся в подвале экрана**
 - xmlns:bnb="clr-namespace:BottomBar.XamarinForms;assembly=BottomBar.XamarinForms"
 - x:Class="TrainingConstructor.Pages.YourProjectName"
 - `bnb:BottomBarPage`
 - public `partial` class : Page
