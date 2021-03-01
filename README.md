### Folder
* Forms
  * 화면 Frame
* Controll
  * ToggleButton추가 컨트롤러
* Macro
  * 메크로Parsing Class
* Model
  * 각 메크로 RegistryKey와 LoadKey DTO

## DataGridView Button Toggle
### AMD.cs
            ToggleButtonCell btnCell = new ToggleButtonCell();

            viewer.Rows.Add();
            btnCell.Value = macro.m_title;
            viewer.Rows[i++].Cells[0] = btnCell; 
             
