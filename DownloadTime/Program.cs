
Console.WriteLine("" +
    "*****************************************\n" +
    "Created by R4mBLe_\n" +
    "Write file size in GB\n" +
    "And download speed in Mbps/s\n" +
    "*****************************************\n");
double speed;
double size;
string size_;
string speed_;
Console.WriteLine("Enter file size: ");
size_ =Console.ReadLine();
size_ = size_.Replace('.', ',');
size = Double.Parse(size_);
Console.WriteLine("Enter download speed: ");
speed_ = Console.ReadLine();
speed_ = speed_.Replace('.', ',');
speed = Double.Parse(speed_);
speed = speed * 0.1;

int hours = Convert.ToInt32(((size*1000)/speed)/3600);
int minutes = Convert.ToInt32(((size * 1000) / speed) % 3600 / 60);
int seconds = Convert.ToInt32(((size * 1000) / speed) % 3600 % 60);
Console.WriteLine($"The file will download in {hours} hours {minutes} minutes {seconds} seconds");
Console.ReadLine();
