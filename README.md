# FlappyPlacidPlasticDuck
 
![Iyv9B2vMS2bDpkQgvb9GUDmy_N7pciTDInutBtdSkEvfwzAdNRCVDov_igFhsOnshbgkPB3wuEJyebIGXgVxfZzlsWbK-NpTmkSJsk0At1DpKtqJynBJKuiWvZPjUjoyvt7p0f3IhctFMhlHD0Ha5e0DL7YwVTdZnjLFkwS-Rkn7aNLFpKijIYp9XnhOF17iokaW0wVCVzOn0QYO2-GF1L](https://github.com/Tsunehiko511/FlappyPlacidPlasticDuck/assets/6568021/d8ba8fb7-688c-4718-8cde-60b230934c8e)


```
class Duck
{
  プレイヤの入力で上昇
}
class Score
{
 得点の管理
}
class GameManager
{
  ゲームの状態管理
}
class Pipe
{
  左に動く
}
class PipeGenerator
{
  パイプの生成
}

Duck --> Score
Duck --> GameManager
PipeGenerator --> Pipe
Duck --> Pipe : 当たり判定
```

http://sujoyu.github.io/plantuml-previewer/
