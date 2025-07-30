using MeCab;

var mecab = MeCabTagger.Create();  // 解析器のインスタンスを作成
var sampleText = "これはテスト音声です。";  // サンプルテキスト
var nodes = mecab.ParseToNodes(sampleText);  // 形態素解析を実行

foreach(var node in nodes)
{
    Console.WriteLine($"{node.Surface} - {node.Feature}");
}

