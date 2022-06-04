
Console.WriteLine("" +
    "*****************************************\n" +
    "Created by R4mBLe_\n" +
    "Примечание: Размеры файла указывать в ГБ,\n" +
    "а скорость загрузки в Мбит\n" +
    "*****************************************\n");
double speed;
double size;
string size_;
string speed_;
Console.WriteLine("Введите размер файла: ");
size_ =Console.ReadLine();
size_ = size_.Replace('.', ',');
size = Double.Parse(size_);
Console.WriteLine("Введите скорость загрузки: ");
speed_ = Console.ReadLine();
speed_ = speed_.Replace('.', ',');
speed = Double.Parse(speed_);
speed = speed * 0.1;

int hours = Convert.ToInt32(((size*1000)/speed)/3600);
int minutes = Convert.ToInt32(((size * 1000) / speed) % 3600 / 60);
int seconds = Convert.ToInt32(((size * 1000) / speed) % 3600 % 60);
Console.WriteLine($"файл загрузится за {hours} часов {minutes} минут {seconds} секунд");
Console.ReadLine();
