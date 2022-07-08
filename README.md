# AppIcon change crashes .NET MAUI app when MediaPicker is invoked

Steps to reproduce issue:

1. Create fresh .NET MAUI app
2. Replace the logic in OnCounterClicked() method to invoke MediaPicker
3. Run app which should work fine
4. Replace the appicon.svg with another svg file but same name i.e. appicon.svg
5. Clean project and clean solution (double clean to make sure it's CLEAN!)
6. Update project file and remove ForegroundFile so that only Include is used to define app icon because it's a single file
7. Run the project and click button to invoke MediaPicker
8. App crashed!