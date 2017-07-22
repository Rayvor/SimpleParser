SimpleParser
======
<p>Programm for parsing sites.</p>
<p>Программа для парсинга сайтов.</p>


Настройки. Settings
======

```
Start Page ID – Начальное целочисленное число для тега {%PageID%}

End Page ID – Конечное целочисленное число для тега {%PageID%}

Base URL – Базовый адрес страницы</<p>

Prefix – Префикс для базового адреса страницы (например, для парсинга сразу с нескольких страниц)
  {%PageID%} – тег указывающий целочисленное число в отрезке от Start Page ID до End Page ID. 
               Используется в строке Prefix.
               
Selector – Селектор html тега (например, a, b, h1 и т.д.)

Content – Класс селектора
```

Пример. Example
======
Нужно получить названия статей с сайта http://site.com

```
view-source:http://site.com
```

```
<div>
    < div>    
      ...
        < a href = "http://site.com/title1.html" class="post__title_link">Название статьи</a>
        < a href = "http://site.com/title2.html" class="post__title_link">Название статьи</a>
        < a href = "http://site.com/title3.html" class="post__title_link">Название статьи</a>
      ...
     < /div>
</div>
```
Для второй страницы:
```
view-source:http://site.com/?page=2
```

```
<div>
    < div>    
      ...
        < a href = "http://site.com/title4.html" class="post__title_link">Название статьи</a>
        < a href = "http://site.com/title5.html" class="post__title_link">Название статьи</a>
        < a href = "http://site.com/title6.html" class="post__title_link">Название статьи</a>
      ...
     < /div>
</div>
```

Для этого примера:

```
  Base URL = http://site.com/
  
  Prefix = ?page={%PageID%}
  
  Selector = a
  
  Content = post__title_link
```
  
